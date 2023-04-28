﻿using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.services
{
    internal class PostServices
    {
        public static List<PostDTO>Get()
        {

            var data = DataAccessFactory.PostData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PostDTO, PostDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PostDTO>>(data);
            return mapped;
        }
        public static PostDTO Get(int id)
        {
            var data = DataAccessFactory.PostData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Post, PostDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PostDTO>(data);
            return mapped;
        }
        public static PostCommentDTO GetwithComments(int id)
        {
            var data = DataAccessFactory.PostData().Read(id);
            var cfg = new MapperConfiguration(c =>
             {
                 c.CreateMap<Post, PostCommentDTO>();
                 c.CreateMap<Comment, CommentDTO>();
             });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PostCommentDTO>(data);
            return mapped;
        }

    }
}
