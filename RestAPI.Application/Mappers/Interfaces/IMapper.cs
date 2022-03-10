using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Application.Mappers.Interfaces
{
    public interface IMapper<TDto, TEntity>
    {
        public TEntity MapperDTOToEntity(TDto dto);
        public TDto MapperEntityToDTO(TEntity entity);
        public IEnumerable<TDto> MapperDTOToList(IEnumerable<TEntity> entities);
    }
}
