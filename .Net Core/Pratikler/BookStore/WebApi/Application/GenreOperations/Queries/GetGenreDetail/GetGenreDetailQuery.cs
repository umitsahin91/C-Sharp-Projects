﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DBOperations;

namespace WebApi.Application.GenreOperations.Queries.GetGenreDetail
{
    public class GetGenreDetailQuery
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public int GenreId { get; set; }

        public GetGenreDetailQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public GenreDetailViewModel Handle()
        {
            var genre = _context.Genres.SingleOrDefault(x => x.Id == GenreId);
            if (genre is null)
                throw new InvalidOperationException("Kitap türü bulunamadı");

            return _mapper.Map<GenreDetailViewModel>(genre);
            
        }
    }
    public class GenreDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
