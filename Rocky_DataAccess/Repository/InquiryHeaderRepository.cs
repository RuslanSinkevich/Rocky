﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rocky.Data;
using Rocky.Models;
using Rocky_DataAccess.Repository.IRepository;
using Rocky_Models;
using Rocky_Utilitu;

namespace Rocky_DataAccess.Repository
{
    public class InquiryHeaderRepository : Repository<InquiryHeader>, IInquiryHeaderRepository
    {
        private readonly ApplicationDbContext _db;

        public InquiryHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(InquiryHeader obj)
        {
            _db.InquiryHeader.Update(obj);

        }
    }
}
