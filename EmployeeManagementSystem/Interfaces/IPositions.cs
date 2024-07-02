using EmployeeManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IPositions
    {
        IQueryable<dynamic> GetPositions();
        Position GetPositionById(string id);
        void AddPosition(Position position);
        void UpdatePosition(Position position);
        void DeletePosition(string id);
        (IQueryable<dynamic> Positions, int totalPositions, int TotalPages) GetPositions(int page, int pageSize);
    }
}
