using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem.Services
{
    public class PositionsService : IPositions
    {
        private readonly DataClasses1DataContext _context = new DataClasses1DataContext();

        //public PositionsService()
        //{
        //    _context = new DatabaseDataContext();
        //}

        public void AddPosition(Positon position)
        {
            try
            {
                position.PositionID = System.Guid.NewGuid().ToString();
                _context.Positons.InsertOnSubmit(position);
                _context.SubmitChanges();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public void DeletePosition(string id)
        {
            try
            {
                Positon position = _context.Positons.FirstOrDefault(p => p.PositionID == id);
                _context.Positons.DeleteOnSubmit(position);
                _context.SubmitChanges();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public List<Positon> GetPositions()
        {
            try
            {
                return _context.Positons.ToList();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public Positon GetPositionById(string id)
        {
            try
            {
                return _context.Positons.FirstOrDefault(p => p.PositionID == id);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public void UpdatePosition(Positon position)
        {
            try
            {
                Positon oldPosition = _context.Positons.FirstOrDefault(p => p.PositionID == position.PositionID);
                oldPosition.PositionName = position.PositionName;
                _context.SubmitChanges();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public (List<Positon> Positions, int totalPositions, int TotalPages) GetPositions(int page, int pageSize)
        {
            try
            {
                int totalPositions = _context.Positons.Count();
                int totalPages = (int)System.Math.Ceiling((double)totalPositions / pageSize);

                List<Positon> positions = _context.Positons
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();
                return (positions, totalPositions, totalPages);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
    }
}
