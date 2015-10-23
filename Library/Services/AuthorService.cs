﻿using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class AuthorService
    {
        AuthorRepository _authorRepository;

        public AuthorService(RepositoryFactory repoFactory)
        {
            _authorRepository = repoFactory.GetAuthorRepository();
        }

        public IEnumerable<Author> All()
        {
            return _authorRepository.All();
        } 
    }
}