using EmployeeManagementSystem.Interfaces;
using EmployeeManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem.Services
{
    public class PositionsService : IPositions
    {
        private readonly DatabaseDataContext _context = new DatabaseDataContext();

        //public PositionsService()
        //{
        //    _context = new DatabaseDataContext();
        //}

        public void AddPosition(Position position)
        {
            try
            {
                position.PositionID = System.Guid.NewGuid().ToString();
                _context.Positions.InsertOnSubmit(position);
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
                Position position = _context.Positions.FirstOrDefault(p => p.PositionID == id);
                _context.Positions.DeleteOnSubmit(position);
                _context.SubmitChanges();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public List<Position> GetPositions()
        {
            try
            {
                return _context.Positions.ToList();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public Position GetPositionById(string id)
        {
            try
            {
                return _context.Positions.FirstOrDefault(p => p.PositionID == id);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public void UpdatePosition(Position position)
        {
            try
            {
                Position oldPosition = _context.Positions.FirstOrDefault(p => p.PositionID == position.PositionID);
                oldPosition.PositionName = position.PositionName;
                _context.SubmitChanges();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }

        public (List<Position> Positions, int totalPositions, int TotalPages) GetPositions(int page, int pageSize)
        {
            try
            {
                int totalPositions = _context.Positions.Count();
                int totalPages = (int)System.Math.Ceiling((double)totalPositions / pageSize);

                List<Position> positions = _context.Positions
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
