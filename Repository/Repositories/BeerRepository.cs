﻿using Data.DBModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class BeerRepository : IBeerRepository {

        private readonly DatabaseContext _context;

        public BeerRepository(DatabaseContext context) {
            _context = context;
        }

        public Beer Add(Beer entity) {
            try {
                _context.Add(entity);
                _context.SaveChanges();
                return _context.Beer.Last();
            }catch(Exception e) {
                throw e;
            }
        }

        public bool Add(Product product, Beer beer, List<int> beerTypeBeerList) {
            var result = false;
            using( var transaction = _context.Database.BeginTransaction()) {
                try {
                    _context.Product.Add(product);
                    _context.SaveChanges();
                    var productId = _context.Product.Last().Id;
                    beer.ProductId = productId;
                    _context.Beer.Add(beer);
                    _context.SaveChanges();
                    List<BeerTypeBeer> list = new List<BeerTypeBeer>();
                    for (int i = 0; i < beerTypeBeerList.Count; i++)
                        list.Add(new BeerTypeBeer { BeerTypeId = beerTypeBeerList[i], ProductId = productId });
                    //beerTypeBeerList.ForEach(x => x.ProductId = productId);
                    //_context.BeerTypeBeer.AddRange(beerTypeBeerList);
                    _context.BeerTypeBeer.AddRange(list);
                    _context.SaveChanges();
                    transaction.Commit();
                    result = true;
                }catch(Exception e) {
                    transaction.Rollback();
                }
            }
            return result;
        }

        public bool Delete(int id, int userId) {
            throw new NotImplementedException();
        }

        public Beer Edit(Beer entity, int userId) {
            throw new NotImplementedException();
        }

        public IQueryable<Beer> GetAll() {
            throw new NotImplementedException();
        }
    }
}
