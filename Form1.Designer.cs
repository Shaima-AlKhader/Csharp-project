namespace M11LabShaymaa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSingers = new System.Windows.Forms.TabPage();
            this.lblSinger = new System.Windows.Forms.Label();
            this.btnCreateSinger = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSingerActive = new System.Windows.Forms.TextBox();
            this.txtSingerSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSingerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAlbums = new System.Windows.Forms.TabPage();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.btnCreateAlbums = new System.Windows.Forms.Button();
            this.cBoxSinger = new System.Windows.Forms.ComboBox();
            this.txtAName = new System.Windows.Forms.TextBox();
            this.DateRelease = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageSongs = new System.Windows.Forms.TabPage();
            this.lblSong = new System.Windows.Forms.Label();
            this.btnCreateSong = new System.Windows.Forms.Button();
            this.cBoxAlbum = new System.Windows.Forms.ComboBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtTitleSong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageAlbumSingersSong = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowSongs = new System.Windows.Forms.Button();
            this.btnShowAlb = new System.Windows.Forms.Button();
            this.lst_Songs = new System.Windows.Forms.ListBox();
            this.lst_Albums = new System.Windows.Forms.ListBox();
            this.lst_Singers = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPageSingers.SuspendLayout();
            this.tabPageAlbums.SuspendLayout();
            this.tabPageSongs.SuspendLayout();
            this.tabPageAlbumSingersSong.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSingers);
            this.tabControl1.Controls.Add(this.tabPageAlbums);
            this.tabControl1.Controls.Add(this.tabPageSongs);
            this.tabControl1.Controls.Add(this.tabPageAlbumSingersSong);
            this.tabControl1.Location = new System.Drawing.Point(158, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(444, 267);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChange);
            // 
            // tabPageSingers
            // 
            this.tabPageSingers.Controls.Add(this.lblSinger);
            this.tabPageSingers.Controls.Add(this.btnCreateSinger);
            this.tabPageSingers.Controls.Add(this.label3);
            this.tabPageSingers.Controls.Add(this.txtSingerActive);
            this.tabPageSingers.Controls.Add(this.txtSingerSurname);
            this.tabPageSingers.Controls.Add(this.label2);
            this.tabPageSingers.Controls.Add(this.txtSingerName);
            this.tabPageSingers.Controls.Add(this.label1);
            this.tabPageSingers.Location = new System.Drawing.Point(4, 24);
            this.tabPageSingers.Name = "tabPageSingers";
            this.tabPageSingers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSingers.Size = new System.Drawing.Size(436, 239);
            this.tabPageSingers.TabIndex = 0;
            this.tabPageSingers.Text = "Manage Singers";
            this.tabPageSingers.UseVisualStyleBackColor = true;
            // 
            // lblSinger
            // 
            this.lblSinger.AutoSize = true;
            this.lblSinger.Location = new System.Drawing.Point(21, 209);
            this.lblSinger.Name = "lblSinger";
            this.lblSinger.Size = new System.Drawing.Size(167, 15);
            this.lblSinger.TabIndex = 7;
            this.lblSinger.Text = "Fill the form to create a singer ";
            // 
            // btnCreateSinger
            // 
            this.btnCreateSinger.Location = new System.Drawing.Point(197, 142);
            this.btnCreateSinger.Name = "btnCreateSinger";
            this.btnCreateSinger.Size = new System.Drawing.Size(75, 23);
            this.btnCreateSinger.TabIndex = 6;
            this.btnCreateSinger.Text = "Create";
            this.btnCreateSinger.UseVisualStyleBackColor = true;
            this.btnCreateSinger.Click += new System.EventHandler(this.btnCreateSinger_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Active Since :";
            // 
            // txtSingerActive
            // 
            this.txtSingerActive.Location = new System.Drawing.Point(133, 113);
            this.txtSingerActive.Name = "txtSingerActive";
            this.txtSingerActive.Size = new System.Drawing.Size(139, 23);
            this.txtSingerActive.TabIndex = 4;
            // 
            // txtSingerSurname
            // 
            this.txtSingerSurname.Location = new System.Drawing.Point(133, 77);
            this.txtSingerSurname.Name = "txtSingerSurname";
            this.txtSingerSurname.Size = new System.Drawing.Size(139, 23);
            this.txtSingerSurname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname :";
            // 
            // txtSingerName
            // 
            this.txtSingerName.Location = new System.Drawing.Point(133, 34);
            this.txtSingerName.Name = "txtSingerName";
            this.txtSingerName.Size = new System.Drawing.Size(139, 23);
            this.txtSingerName.TabIndex = 1;
            this.txtSingerName.TextChanged += new System.EventHandler(this.txtSingerName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPageAlbums
            // 
            this.tabPageAlbums.Controls.Add(this.lblAlbum);
            this.tabPageAlbums.Controls.Add(this.btnCreateAlbums);
            this.tabPageAlbums.Controls.Add(this.cBoxSinger);
            this.tabPageAlbums.Controls.Add(this.txtAName);
            this.tabPageAlbums.Controls.Add(this.DateRelease);
            this.tabPageAlbums.Controls.Add(this.label6);
            this.tabPageAlbums.Controls.Add(this.label5);
            this.tabPageAlbums.Controls.Add(this.label4);
            this.tabPageAlbums.Location = new System.Drawing.Point(4, 24);
            this.tabPageAlbums.Name = "tabPageAlbums";
            this.tabPageAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlbums.Size = new System.Drawing.Size(436, 239);
            this.tabPageAlbums.TabIndex = 1;
            this.tabPageAlbums.Text = "Manage Albums";
            this.tabPageAlbums.UseVisualStyleBackColor = true;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(16, 209);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(175, 15);
            this.lblAlbum.TabIndex = 8;
            this.lblAlbum.Text = "Fill the form to create an Album";
            // 
            // btnCreateAlbums
            // 
            this.btnCreateAlbums.Location = new System.Drawing.Point(264, 150);
            this.btnCreateAlbums.Name = "btnCreateAlbums";
            this.btnCreateAlbums.Size = new System.Drawing.Size(75, 23);
            this.btnCreateAlbums.TabIndex = 7;
            this.btnCreateAlbums.Text = "Create";
            this.btnCreateAlbums.UseVisualStyleBackColor = true;
            this.btnCreateAlbums.Click += new System.EventHandler(this.btnCreateAlbums_Click);
            // 
            // cBoxSinger
            // 
            this.cBoxSinger.FormattingEnabled = true;
            this.cBoxSinger.Location = new System.Drawing.Point(139, 109);
            this.cBoxSinger.Name = "cBoxSinger";
            this.cBoxSinger.Size = new System.Drawing.Size(200, 23);
            this.cBoxSinger.TabIndex = 6;
            // 
            // txtAName
            // 
            this.txtAName.Location = new System.Drawing.Point(139, 34);
            this.txtAName.Name = "txtAName";
            this.txtAName.Size = new System.Drawing.Size(200, 23);
            this.txtAName.TabIndex = 5;
            // 
            // DateRelease
            // 
            this.DateRelease.Location = new System.Drawing.Point(139, 72);
            this.DateRelease.Name = "DateRelease";
            this.DateRelease.Size = new System.Drawing.Size(200, 23);
            this.DateRelease.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Album Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Release Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Singer :";
            // 
            // tabPageSongs
            // 
            this.tabPageSongs.Controls.Add(this.lblSong);
            this.tabPageSongs.Controls.Add(this.btnCreateSong);
            this.tabPageSongs.Controls.Add(this.cBoxAlbum);
            this.tabPageSongs.Controls.Add(this.txtLength);
            this.tabPageSongs.Controls.Add(this.txtTitleSong);
            this.tabPageSongs.Controls.Add(this.label9);
            this.tabPageSongs.Controls.Add(this.label8);
            this.tabPageSongs.Controls.Add(this.label7);
            this.tabPageSongs.Location = new System.Drawing.Point(4, 24);
            this.tabPageSongs.Name = "tabPageSongs";
            this.tabPageSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSongs.Size = new System.Drawing.Size(436, 239);
            this.tabPageSongs.TabIndex = 2;
            this.tabPageSongs.Text = "Manage Songs";
            this.tabPageSongs.UseVisualStyleBackColor = true;
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Location = new System.Drawing.Point(20, 210);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(158, 15);
            this.lblSong.TabIndex = 11;
            this.lblSong.Text = "Fill the form to create a song";
            // 
            // btnCreateSong
            // 
            this.btnCreateSong.Location = new System.Drawing.Point(279, 148);
            this.btnCreateSong.Name = "btnCreateSong";
            this.btnCreateSong.Size = new System.Drawing.Size(75, 23);
            this.btnCreateSong.TabIndex = 10;
            this.btnCreateSong.Text = "Create";
            this.btnCreateSong.UseVisualStyleBackColor = true;
            this.btnCreateSong.Click += new System.EventHandler(this.btnCreateSong_Click);
            // 
            // cBoxAlbum
            // 
            this.cBoxAlbum.FormattingEnabled = true;
            this.cBoxAlbum.Location = new System.Drawing.Point(154, 119);
            this.cBoxAlbum.Name = "cBoxAlbum";
            this.cBoxAlbum.Size = new System.Drawing.Size(200, 23);
            this.cBoxAlbum.TabIndex = 9;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(154, 82);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(200, 23);
            this.txtLength.TabIndex = 8;
            // 
            // txtTitleSong
            // 
            this.txtTitleSong.Location = new System.Drawing.Point(154, 35);
            this.txtTitleSong.Name = "txtTitleSong";
            this.txtTitleSong.Size = new System.Drawing.Size(200, 23);
            this.txtTitleSong.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Song Title :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Length in Secs  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Album :";
            // 
            // tabPageAlbumSingersSong
            // 
            this.tabPageAlbumSingersSong.Controls.Add(this.btnDelete);
            this.tabPageAlbumSingersSong.Controls.Add(this.btnShowSongs);
            this.tabPageAlbumSingersSong.Controls.Add(this.btnShowAlb);
            this.tabPageAlbumSingersSong.Controls.Add(this.lst_Songs);
            this.tabPageAlbumSingersSong.Controls.Add(this.lst_Albums);
            this.tabPageAlbumSingersSong.Controls.Add(this.lst_Singers);
            this.tabPageAlbumSingersSong.Location = new System.Drawing.Point(4, 24);
            this.tabPageAlbumSingersSong.Name = "tabPageAlbumSingersSong";
            this.tabPageAlbumSingersSong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlbumSingersSong.Size = new System.Drawing.Size(436, 239);
            this.tabPageAlbumSingersSong.TabIndex = 3;
            this.tabPageAlbumSingersSong.Text = "Singers, Albums and Songs";
            this.tabPageAlbumSingersSong.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(294, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowSongs
            // 
            this.btnShowSongs.Location = new System.Drawing.Point(157, 163);
            this.btnShowSongs.Name = "btnShowSongs";
            this.btnShowSongs.Size = new System.Drawing.Size(120, 23);
            this.btnShowSongs.TabIndex = 4;
            this.btnShowSongs.Text = "Show Songs>";
            this.btnShowSongs.UseVisualStyleBackColor = true;
            this.btnShowSongs.Click += new System.EventHandler(this.btnShowSongs_Click);
            // 
            // btnShowAlb
            // 
            this.btnShowAlb.Location = new System.Drawing.Point(17, 133);
            this.btnShowAlb.Name = "btnShowAlb";
            this.btnShowAlb.Size = new System.Drawing.Size(120, 23);
            this.btnShowAlb.TabIndex = 3;
            this.btnShowAlb.Text = "Show Albums>";
            this.btnShowAlb.UseVisualStyleBackColor = true;
            this.btnShowAlb.Click += new System.EventHandler(this.btnShowAlb_Click);
            // 
            // lst_Songs
            // 
            this.lst_Songs.FormattingEnabled = true;
            this.lst_Songs.ItemHeight = 15;
            this.lst_Songs.Location = new System.Drawing.Point(294, 32);
            this.lst_Songs.Name = "lst_Songs";
            this.lst_Songs.Size = new System.Drawing.Size(120, 154);
            this.lst_Songs.TabIndex = 2;
            // 
            // lst_Albums
            // 
            this.lst_Albums.FormattingEnabled = true;
            this.lst_Albums.ItemHeight = 15;
            this.lst_Albums.Location = new System.Drawing.Point(157, 32);
            this.lst_Albums.Name = "lst_Albums";
            this.lst_Albums.Size = new System.Drawing.Size(120, 124);
            this.lst_Albums.TabIndex = 1;
            // 
            // lst_Singers
            // 
            this.lst_Singers.FormattingEnabled = true;
            this.lst_Singers.ItemHeight = 15;
            this.lst_Singers.Location = new System.Drawing.Point(17, 32);
            this.lst_Singers.Name = "lst_Singers";
            this.lst_Singers.Size = new System.Drawing.Size(120, 94);
            this.lst_Singers.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 344);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageSingers.ResumeLayout(false);
            this.tabPageSingers.PerformLayout();
            this.tabPageAlbums.ResumeLayout(false);
            this.tabPageAlbums.PerformLayout();
            this.tabPageSongs.ResumeLayout(false);
            this.tabPageSongs.PerformLayout();
            this.tabPageAlbumSingersSong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSingers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSingerActive;
        private System.Windows.Forms.TextBox txtSingerSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSingerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageAlbums;
        private System.Windows.Forms.TabPage tabPageSongs;
        private System.Windows.Forms.TabPage tabPageAlbumSingersSong;
        private System.Windows.Forms.Label lblSinger;
        private System.Windows.Forms.Button btnCreateSinger;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Button btnCreateAlbums;
        private System.Windows.Forms.ComboBox cBoxSinger;
        private System.Windows.Forms.TextBox txtAName;
        private System.Windows.Forms.DateTimePicker DateRelease;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.Button btnCreateSong;
        private System.Windows.Forms.ComboBox cBoxAlbum;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtTitleSong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowSongs;
        private System.Windows.Forms.Button btnShowAlb;
        private System.Windows.Forms.ListBox lst_Songs;
        private System.Windows.Forms.ListBox lst_Albums;
        private System.Windows.Forms.ListBox lst_Singers;
    }
}
