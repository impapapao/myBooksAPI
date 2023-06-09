﻿using myBooksAPI.Db_Context;
using myBooksAPI.Models;
using myBooksAPI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace myBooksAPI.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }


        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.IsRead ? book.DateRead.Value : null,
                Rate = book.IsRead ? book.Rate.Value : null,
                Genre = book.Genre,
                Author = book.Author,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }
    
        public List<Book> GetAllBooks()
        {
            var allBooks = _context.Books.ToList();
            return allBooks;
        }

        public Book GetBookById(int bookid)
        {
            var idBook = _context.Books.FirstOrDefault(n => n.Id == bookid);
            return idBook;
                
        }
    
        public Book UpdateBookById(int bookId, BookVM book)
        {
            var _book = _context.Books.FirstOrDefault(n => n.Id == bookId);
            {
                if(_book != null)
                {
                    _book.title = book.Title;
                    _book.Description = book.Description;
                    _book.IsRead = book.IsRead;
                    _book.DateRead = book.IsRead ? book.DateRead.Value : null;
                    _book.Rate = book.IsRead ? book.Rate.Value : null;
                    _book.Genre = book.Genre;
                    _book.Author = book.Author;
                    _book.CoverUrl = book.CoverUrl;

                    _context.SaveChanges();
                }
                return _book;
            }
        }
    
        public void DeleteBookById(int bookId)
        {
            var _book = _context.Books.FirstOrDefault(n => n.Id == bookId);
            if( _book != null )
            {
                _context.Books.Remove( _book );
                _context.SaveChanges();
            }
        }
    }
}
