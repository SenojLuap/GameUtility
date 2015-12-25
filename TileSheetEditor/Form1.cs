using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using paujo.GameUtility;
using Microsoft.Xna.Framework;

namespace TileSheetEditor {
  
  public partial class MainForm : Form {

    public TileSheet LoadedTileSheet {
      get; set;
    }

    public string TileSheetUrl {
      get; set;
    }

    public Image LoadedImage {
      get; set;
    }

    public string ImageUrl {
      get; set;
    }

    public MainForm() {
      InitializeComponent();
    }


    public int disableEventStack = 0;
    
    public void DisableEvents() {
      disableEventStack++;
    }
    
    public void EnableEvents() {
      disableEventStack--;
      disableEventStack = Math.Max(0, disableEventStack);
    }

    public bool EventsEnabled {
      get {
	return (disableEventStack == 0);
      }
    }

    
    public bool LoadTileSheetFromFile() {
      try {
	if (File.Exists(TileSheetUrl)) {
	  LoadedTileSheet = TileSheet.ReadFromFile(TileSheetUrl);
	  if (LoadedImage != null) LoadedImage.Dispose();
	  Image newImage = null;
	  if (File.Exists(ImageUrl)) newImage = Image.FromFile(ImageUrl, true);
	  if (newImage != null) {
	    LoadedImage = newImage;
	    LoadedTileSheet.TextureKey = Path.GetFileNameWithoutExtension(ImageUrl);
	  } else {
	    LoadedImage = null;
	    LoadedTileSheet.TextureKey = "";
	  }
	  UpdateSizeInFrames();
	}
      } catch (Exception e) {
	System.Console.WriteLine("Exception while reading file: " + e.Message);
	return false;
      }
      return true;
    }


    private void openTileSheetBtn_Click(object sender, EventArgs e) {
      if (!EventsEnabled) return;
      DialogResult tileSheetResult = openTileSheetDialog.ShowDialog();
      if (tileSheetResult == DialogResult.OK) {
	TileSheetUrl = openTileSheetDialog.FileName;
	DialogResult imageResult = openImageDialog.ShowDialog();
	ImageUrl = (imageResult == DialogResult.OK ? openImageDialog.FileName : "");
	if (LoadTileSheetFromFile()) {
	  UpdateControls();
	} else {
	  Console.WriteLine("Error Loading");
	}
      }
    }


    private void frameWidthBox_ValueChanged(object sender, EventArgs e) {
      if (!EventsEnabled) return;
      LoadedTileSheet.FrameWidth = Convert.ToInt32(frameWidthBox.Value);
      UpdateSizeInFrames();
      UpdateOffsetList();
    }

    
    private void frameHeightBox_ValueChanged(object sender, EventArgs e) {
      if (!EventsEnabled) return;
      LoadedTileSheet.FrameHeight = Convert.ToInt32(frameHeightBox.Value);
      UpdateSizeInFrames();
      UpdateOffsetList();
    }


    private void offsetListBox_SelectedIndexChanged(object sender, EventArgs e) {
      if (!EventsEnabled) return;
      //if (offsetListBox.SelectedIndices.Count == 0) {
	//SelectedOffset = -1;
      //} else {
	//SelectedOffset = offsetListBox.SelectedIndices[0];
      //}
      
      UpdateOffsetControls();
    }
  

    private void defaultChkBox_CheckedChanged(object sender, EventArgs e) {
      if (!EventsEnabled) return;
      int SelectedOffset = offsetListBox.SelectedIndex;
      if (SelectedOffset < 0) return;
      if (defaultChkBox.Checked) {
	if (LoadedTileSheet.FrameOffsets.ContainsKey(SelectedOffset)) {
	  LoadedTileSheet.FrameOffsets.Remove(SelectedOffset);
	  UpdateOffsetList();
	  UpdateOffsetControls();
	}
      } else {
	if (!LoadedTileSheet.FrameOffsets.ContainsKey(SelectedOffset)) {
	  LoadedTileSheet.FrameOffsets.Add(SelectedOffset, new Microsoft.Xna.Framework.Point(0, 0));
	  UpdateOffsetList();
	  UpdateOffsetControls();
	}
      }
    }


    private void saveBtn_Click(object sender, EventArgs e) {
      if (!EventsEnabled) return;
      if (LoadedTileSheet != null)
	TileSheet.WriteToFile(TileSheetUrl, LoadedTileSheet);
    }

    
    public void UpdateSizeInFrames() {
      if (LoadedImage == null) {
	LoadedTileSheet.SizeInFrames = new Microsoft.Xna.Framework.Point(1, 1);
	LoadedTileSheet.TileCount = -1;
	return;
      }
      GraphicsUnit gu = GraphicsUnit.Pixel;
      System.Drawing.Rectangle boundRect = System.Drawing.Rectangle.Round(LoadedImage.GetBounds(ref gu));
      LoadedTileSheet.SizeInFrames = new Microsoft.Xna.Framework.Point(boundRect.Width / LoadedTileSheet.FrameWidth, boundRect.Height / LoadedTileSheet.FrameHeight);
      LoadedTileSheet.TileCount = -1;
    }
    
    
    public void UpdateControls() {
      DisableEvents();
      tileSheetFile.Text = Path.GetFileName(TileSheetUrl);
      imageFile.Text = (LoadedImage == null ? "" : Path.GetFileName(ImageUrl));
      frameWidthBox.Value = LoadedTileSheet.FrameWidth;
      frameHeightBox.Value = LoadedTileSheet.FrameHeight;
      defaultOffsetX.Value = LoadedTileSheet.DefaultFrameOffset.X;
      defaultOffsetY.Value = LoadedTileSheet.DefaultFrameOffset.Y;
      UpdateOffsetList();
      EnableEvents();
    }


    public void UpdateOffsetList() {
      DisableEvents();
      int oldSelection = offsetListBox.SelectedIndex;
      List<string> offsets = new List<string>();
      for (int i = 0; i < LoadedTileSheet.TileCount; i++) {
	StringBuilder buf = new StringBuilder();
	buf.Append(i);
	buf.Append(": ");
	if (LoadedTileSheet.FrameOffsets.ContainsKey(i)) {
	  Microsoft.Xna.Framework.Point offset = LoadedTileSheet.FrameOffsets[i];
	  buf.Append("<");
	  buf.Append(offset.X);
	  buf.Append(", ");
	  buf.Append(offset.Y);
	  buf.Append(">");
	} else {
	  buf.Append("Default");
	}
	offsets.Add(buf.ToString());
      }
      offsetListBox.DataSource = null;
      offsetListBox.DataSource = offsets;
      offsetListBox.SelectedIndex = oldSelection;
      EnableEvents();
    }


    public void UpdateOffsetControls() {
      DisableEvents();
      if (offsetListBox.SelectedIndex < 0) {
	defaultChkBox.Enabled = false;
	offsetX.Enabled = false;
	offsetY.Enabled = false;
      } else {
	defaultChkBox.Enabled = true;
	if (LoadedTileSheet.FrameOffsets.ContainsKey(offsetListBox.SelectedIndex)) {
	  defaultChkBox.Checked = false;
	  offsetX.Enabled = true;
	  offsetY.Enabled = true;
	  Microsoft.Xna.Framework.Point offset =
	    LoadedTileSheet.FrameOffsets[offsetListBox.SelectedIndex];
	  offsetX.Value = offset.X;
	  offsetY.Value = offset.Y;
	} else {
	  defaultChkBox.Checked = true;
	  offsetX.Value = 0;
	  offsetY.Value = 0;
	  offsetX.Enabled = false;
	  offsetY.Enabled = false;
	}
      }
      EnableEvents();
    }

    private void defaultOffset_ValueChanged(object sender, EventArgs e) {
      int newDefaultOffsetX = Convert.ToInt32(defaultOffsetX.Value);
      int newDefaultOffsetY = Convert.ToInt32(defaultOffsetY.Value);
      Misc.pln("" + newDefaultOffsetX + ", " + newDefaultOffsetY);
      LoadedTileSheet.DefaultFrameOffset = new Microsoft.Xna.Framework.Point(newDefaultOffsetX,
									     newDefaultOffsetY);
    }

    private void newTileSheetBtn_Click(object sender, EventArgs e) {
      // TODO
    }
  }
}
