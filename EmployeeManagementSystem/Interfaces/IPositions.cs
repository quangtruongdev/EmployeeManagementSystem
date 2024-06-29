using EmployeeManagementSystem.Models;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Interfaces
{
    public interface IPositions
    {
        List<Positon> GetPositions();
        Positon GetPositionById(string id);
        void AddPosition(Positon position);
        void UpdatePosition(Positon position);
        void DeletePosition(string id);
        (List<Positon> Positions, int totalPositions, int TotalPages) GetPositions(int page, int pageSize);
    }
}
