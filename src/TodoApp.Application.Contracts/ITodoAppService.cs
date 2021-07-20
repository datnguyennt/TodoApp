using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace TodoApp
{
	public interface ITodoAppService : IApplicationService
	{
		Task<List<TodoItemDto>> GetListAsync(); // Hien thi list item
		Task<TodoItemDto> CreateAsync(string text); // Them item
		Task DeleteAsync(Guid id); // Xoa
	}
}
