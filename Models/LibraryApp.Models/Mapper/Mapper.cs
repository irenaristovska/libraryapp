﻿using LibraryApp.Domain;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp.Models.Mapper
{
    public static class Mapper
    {
        #region ToModel

        public static BookModel ToModel(this Book book)
        {
            return new BookModel
            {
                Id = book.Id,
                ImageUrl = book.ImageUrl,
                OriginalTitle = book.OriginalTitle,
                PagesNum = book.PagesNum,
                PublishingHouse = book.PublishingHouse,
                Rating = book.Rating,
                Title = book.Title,
                Description = book.Description,
                Authors = book.BookAuthors.ToAuthorModelList(),
                Genres = book.BookGenres.ToGenreModelList(),
                Language = book.Language,
                Isbn = book.ISBN
            };
        }

        public static AuthorModel ToModel(this Author author)
        {
            return new AuthorModel
            {
                Id = author.Id,
                ImageUrl = author.Avatar,
                Biography = author.Bio,
                FirstName = author.Firstname,
                LastName = author.Lastname
            };
        }

        public static RoleModel ToModel(this Role role)
        {
            return new RoleModel
            {
                Id = role.Id,
                Title = role.Title,
                Tag = role.Tag
            };
        }

        public static GenreModel ToModel(this Genre genre)
        {
            return new GenreModel
            {
                Id = genre.Id,
                Title = genre.Title
            };
        }

        public static UserModel ToModel(this User user)
        {
            return new UserModel
            {
                Id = user.Id,
                ImageUrl = user.ImageUrl,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                IsActive = user.IsActive,
                Roles = user.UserRoles.ToRoleModelList()
            };
        }

        public static List<RoleModel> ToRoleModelList(this IEnumerable<UserRole> userRoles)
        {
            return userRoles.Select(r => r.Role.ToModel()).ToList();
        }

        public static List<GenreModel> ToGenreModelList(this IEnumerable<BookGenre> bookGenres)
        {
            return bookGenres.Select(g => g.Genre.ToModel()).ToList();
        }

        public static List<AuthorModel> ToAuthorModelList(this IEnumerable<BookAuthor> bookAuthors)
        {
            return bookAuthors.Select(a => a.Author.ToModel()).ToList();
        }

        #endregion


        #region ToDomain

        public static Book ToDomain(this BookModel model)
        {
            return new Book
            {
                Id = model.Id,
                ImageUrl = model.ImageUrl,
                OriginalTitle = model.OriginalTitle,
                PagesNum = model.PagesNum,
                PublishingHouse = model.PublishingHouse,
                Rating = model.Rating,
                Title = model.Title,
                Description = model.Description,
                Language = model.Language,
                ISBN = model.Isbn
            };
        }

        public static Author ToDomain(this AuthorModel model)
        {
            return new Author
            {
                Id = model.Id,
                Avatar = model.ImageUrl,
                Bio = model.Biography,
                Firstname = model.FirstName,
                Lastname = model.LastName
            };
        }

        public static Role ToDomain(this RoleModel model)
        {
            return new Role
            {
                Id = model.Id,
                Title = model.Title,
                Tag = model.Tag
            };
        }

        public static Genre ToDomain(this GenreModel model)
        {
            return new Genre
            {
                Id = model.Id,
                Title = model.Title
            };
        }

        public static User ToDomain(this UserModel model)
        {
            return new User
            {
                Id = model.Id,
                FirstName = model.FirstName,
                UserName = model.UserName,
                LastName = model.LastName,
                ImageUrl = model.ImageUrl,
                IsActive = model.IsActive,
                Email = model.Email
            };
        }

        #endregion
    }
}
