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

    
    public bool LoadTileSheetFromFile(string path) {
      string dir = Path.GetDirectoryName(path);
      Image newImage = Image.FromFile(path, true);
      if (newImage == null) return false;
      if (LoadedImage != null) LoadedImage.Dispose();
      LoadedImage = newImage;
      string fileName = Path.GetFileNameWithoutExtension(path) + ".jts";
      TileSheetUrl = Path.Combine(dir, fileName);
      try {
	if (File.Exists(TileSheetUrl)) {
	  LoadedTileSheet = TileSheet.ReadFromFile(TileSheetUrl);
	} else {
	  LoadedTileSheet = new TileSheet();
	  GraphicsUnit gu = GraphicsUnit.Pixel;
	  System.Drawing.Rectangle boundRect = System.Drawing.Rectangle.Round(LoadedImage.GetBounds(ref gu));
	  LoadedTileSheet.FrameWidth = boundRect.Width/2;
	  LoadedTileSheet.FrameHeight = boundRect.Height/2;
	  
	}
	UpdateSizeInFrames();
	LoadedTileSheet.TextureKey = Path.GetFileNameWithoutExtension(path);
	//Console.WriteLine(LoadedTileSheet.SizeInFrames + " " + LoadedTileSheet.TileCount
      } catch (Exception e) {
	System.Console.WriteLine("Exception while reading file: " + path + ": " +
				 e.Message);
	return false;
      }
      return true;
    }


    private void openTileSheetBtn_Click(object sender, EventArgs e) {
      if (!EventsEnabled) return;
      DialogResult result = openTileSheetDialog.ShowDialog();
      if (result == DialogResult.OK) {
	if (LoadTileSheetFromFile(openTileSheetDialog.FileName)) {
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
      GraphicsUnit gu = GraphicsUnit.Pixel;
      System.Drawing.Rectangle boundRect = System.Drawing.Rectangle.Round(LoadedImage.GetBounds(ref gu));
      LoadedTileSheet.SizeInFrames = new Microsoft.Xna.Framework.Point(boundRect.Width / LoadedTileSheet.FrameWidth, boundRect.Height / LoadedTileSheet.FrameHeight);
      LoadedTileSheet.TileCount = -1;
    }
    
    
    public void UpdateControls() {
      DisableEvents();
      tileSheetFile.Text = LoadedTileSheet.TextureKey;
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

  }
}
