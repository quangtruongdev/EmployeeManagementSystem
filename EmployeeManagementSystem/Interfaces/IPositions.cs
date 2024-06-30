using EmployeeManagementSystem.Models;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IPositions
    {
        List<Position> GetPositions();
        Position GetPositionById(string id);
        void AddPosition(Position position);
        void UpdatePosition(Position position);
        void DeletePosition(string id);
        (List<Position> Positions, int totalPositions, int TotalPages) GetPositions(int page, int pageSize);
    }
}
