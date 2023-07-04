using M11LabShaymaa.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M11LabShaymaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSingerName_TextChanged(object sender, EventArgs e)
        {

        }
        MusicDbContext _db = new MusicDbContext();
        private void btnCreateAlbums_Click(object sender, EventArgs e)
        {
            try
            {
                Album album1 = new Album()
                {
                       AlbumName=txtAName.Text,
                       Released=DateRelease.Value,
                       SingerId  = (int)cBoxSinger.SelectedValue, 
                };
                
                _db.Albums.Add(album1);
                _db.SaveChanges();

                lblAlbum.ForeColor = Color.DarkOliveGreen;
                lblAlbum.Text = "Album is successfuly created";
                txtAName.Text = "";
                DateRelease.Value=DateTime.Now;
            }
            catch (Exception ex)
            {
                lblAlbum.Text="An error has occured .More info" + ex.Message;
            }


           
        }

        public void tabControl1_SelectedIndexChange(object sender, EventArgs e)
        {
           if(tabControl1.SelectedTab== tabPageAlbumSingersSong)
            {
                lst_Albums.DataSource=_db.Albums.ToList();
                lst_Albums.ValueMember = "Id";
                lst_Albums.DisplayMember = "AlbumName";

                lst_Singers.DataSource = _db.Singers.ToList();
                lst_Singers.ValueMember = "Id";
                lst_Singers.DisplayMember = "Name";

                lst_Songs.DataSource = _db.Songs.ToList();
                lst_Songs.ValueMember = "Id";
                lst_Songs.DisplayMember = "Title";
                
            }
           else if (tabControl1.SelectedTab == tabPageSongs)
            {
                cBoxAlbum.DataSource = _db.Albums.ToList();
                cBoxAlbum.ValueMember = "Id";
                cBoxAlbum.DisplayMember = "AlbumName";
            }
            else if (tabControl1.SelectedTab == tabPageAlbums)
            {
                cBoxSinger.DataSource = _db.Singers.ToList();
                cBoxSinger.ValueMember = "Id";
                cBoxSinger.DisplayMember = "Name" ;
            }
        }

        private void btnCreateSinger_Click(object sender, EventArgs e)
        {
            try
            {
                Singer singer1 = new Singer()
                {
                    Name=txtSingerName.Text,
                    SureName=txtSingerSurname.Text,
                    ActiveSince=int.Parse(txtSingerActive.Text),
                };
                _db.Singers.Add(singer1);
                _db.SaveChanges();

                lblSinger.ForeColor = Color.DarkOliveGreen;
                lblSinger.Text = "Singer is successfuly created";
                txtSingerName.Text = "";
                txtSingerSurname.Text ="";
                txtSingerActive.Text = "";

            }
            catch (Exception ex)
            {
                lblSinger.Text = "An error has occured .More info" + ex.Message;
            }

        }

        private void btnCreateSong_Click(object sender, EventArgs e)
        {
            try
            {
                Song song1 = new Song()
                {
                    Title = txtTitleSong.Text,
                    Length = int.Parse(txtLength.Text),
                    AlbumId=(int)cBoxAlbum.SelectedValue,
                };
                _db.Songs.Add(song1);
                _db.SaveChanges();

                lblSong.ForeColor = Color.DarkOliveGreen;
                lblSong.Text = "Song is successfuly created";
                txtTitleSong.Text = "";
                txtLength.Text = "";
            }
            catch (Exception ex)
            {
                lblSong.Text = "An error has occured .More info" + ex.Message;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Song SongToDelete =(Song) lst_Songs.SelectedValue;

            _db.Songs.Remove(SongToDelete);
            _db.SaveChanges();
        }

        private void btnShowSongs_Click(object sender, EventArgs e)
        {
            int SelectAlbum = (int)lst_Albums.SelectedValue;
            List<Song> filterSongs = _db.Songs.Where(s => s.AlbumId == SelectAlbum).ToList();

            lst_Songs.DataSource=filterSongs;
            lst_Songs.ValueMember = "Id";
            lst_Songs.DisplayMember = "Title";
        }

        private void btnShowAlb_Click(object sender, EventArgs e)
        {
            int SelectSinger = (int)lst_Singers.SelectedValue;
            List<Album> filterAlbums = _db.Albums.Where(a => a.SingerId == SelectSinger).ToList();

            lst_Albums.DataSource = filterAlbums;
            lst_Albums.ValueMember = "Id";
            lst_Albums.DisplayMember = "AlbumName";
        }
        int a = (int)25.3;

    }
}
