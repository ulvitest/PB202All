
using Academy.Core.Entities;
using Academy.Data;
using Academy.Service.Dtos.GroupDtos;
using Academy.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Academy.Service.Services
{
    public class GroupService : IGroupService
    {
        private readonly AcademyDbContext _context;
        public GroupService()
        {
            _context = new AcademyDbContext();
        }
        public void CreateGroup(GroupCreateDto groupCreateDto)
        {
            if (_context.Groups.Any(g => g.No == groupCreateDto.No))
                throw new Exception("group exist with no..");
            Group group = new Group();
            group.No = groupCreateDto.No;
            group.CreatedDate = groupCreateDto.CreatedDate;
            group.Limit = groupCreateDto.Limit;

            _context.Groups.Add(group);
            _context.SaveChanges();
        }
        public async Task CreateGroupAsync(GroupCreateDto groupCreateDto)
        {
            if (await _context.Groups.AnyAsync(g => g.No == groupCreateDto.No))
                throw new Exception("group exist with no..");
            Group group = new Group();
            group.No = groupCreateDto.No;
            group.CreatedDate = groupCreateDto.CreatedDate;
            group.Limit = groupCreateDto.Limit;

            await _context.Groups.AddAsync(group);
            await _context.SaveChangesAsync();
        }
        public GroupReturnDto GetGroupById(int? id)
        {
            if (id is null)
                throw new Exception("id is null");

            var existGroup = _context.Groups
                .Where(g => g.Id == id)
                .Select(g => new GroupReturnDto()
                {
                    Limit = g.Limit,
                    CreatedDate = g.CreatedDate,
                    No = g.No,
                    Students = g.Students
                })
                .SingleOrDefault();


            if (existGroup is null)
                throw new Exception("group not found");
            return existGroup;
        }
        public Group GetGroupByIdAdmin(int? id)
        {
            if (id is null)
                throw new Exception("id is null");

            var existGroup = _context.Groups
                .Include(g => g.Students)
                .SingleOrDefault(g => g.Id == id);
            if (existGroup is null)
                throw new Exception("group not found");
            return existGroup;
        }
        public async Task<Group> GetGroupByIdAdminAsync(int? id)
        {
            if (id is null)
                throw new Exception("id is null");

            var existGroup = await _context.Groups
                .Include(g => g.Students)
                .SingleOrDefaultAsync(g => g.Id == id);
            if (existGroup is null)
                throw new Exception("group not found");
            return existGroup;
        }
        public async Task<GroupReturnDto> GetGroupByIdAsync(int? id)
        {
            if (id is null)
                throw new Exception("id is null");

            var existGroup = await _context.Groups
                .Where(g => g.Id == id)
                .Select(g => new GroupReturnDto()
                {
                    Limit = g.Limit,
                    CreatedDate = g.CreatedDate,
                    No = g.No,
                    Students = g.Students
                })
                .SingleOrDefaultAsync();


            if (existGroup is null)
                throw new Exception("group not found");
            return existGroup;
        }
        public List<Group> GetGroups() => _context.Groups.Include(g => g.Students).ToList();
        public async Task<List<Group>> GetGroupsAsync() => await _context.Groups.Include(g => g.Students).ToListAsync();
        public async Task DeleteGroupById(int? id)
        {
            var existGroup = await GetGroupByIdAdminAsync(id);

            _context.Groups.Remove(existGroup);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteGroupByIdAsync(int? id)
        {
            var existGroup = await GetGroupByIdAsync(id);
            Group group = new()
            {
                Id = (int)id,
                Limit = existGroup.Limit,
                CreatedDate = existGroup.CreatedDate,
                No = existGroup.No,
            };
            _context.Groups.Remove(group);
            await _context.SaveChangesAsync();
        }
        public void UpdateGroup(int? id, Group group)//pb202,10  pb202 15
        {
            var existGroup = GetGroupById(id);
            if (_context.Groups.Any(g => g.No == group.No && g.Id != id))
                throw new Exception("group exist with no..");
            existGroup.No = group.No;
            existGroup.Limit = group.Limit;
            _context.SaveChanges();
        }
        public async Task UpdateGroupAsync(int? id, Group group)//pb202,10  pb202 15
        {
            var existGroup = await GetGroupByIdAsync(id);
            if (_context.Groups.Any(g => g.No == group.No && g.Id != id))
                throw new Exception("group exist with no..");
            existGroup.No = group.No;
            existGroup.Limit = group.Limit;
            _context.SaveChanges();
        }

        public bool IsExist(string no) => _context.Groups.Any(g => g.No == no);
        public async Task<bool> IsExistAsync(string no) => await _context.Groups.AnyAsync(g => g.No == no);


    }
}
