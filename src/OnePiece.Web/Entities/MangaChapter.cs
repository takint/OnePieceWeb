﻿using System;
using System.Collections.Generic;
using OnePiece.Web.DataAccess.Entities;

namespace OnePiece.Web.Entities
{
    public class MangaChapter : EntityBase
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public DateTime? PublishedDate { get; set; }

        public List<Manga> Mangas { get; set; }
        public int MangaSeasonId { get; set; }
        public MangaSeason MangaSeason { get; set; }
    }
}