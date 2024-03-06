using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Antities
{
    /// <summary>
    /// Базовый класс для всех сущностей
    /// </summary>
    public abstract class BaseEntitiys
    {
        /// <summary>
        /// Уникальный идентификатор сущности
        /// </summary>
        protected Guid Id { get; set; }
        /// <summary>
        /// Дата создания сущности
        /// </summary>
        protected DateTime CreatedDate { get; set; }
        /// <summary>
        /// Метод для сравнения сущностей по айди
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj == null) 
                return false;
            if(obj is not BaseEntitiys entitiys)
                return false;
            if(Id!=entitiys.Id)
                return false;
            return true;
            
        }
        /// <summary>
        /// todo: Домашнее задание понять почему икуалс заставил определить гетхэш код и переписать с исп того что узнаю
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        { 
            return new NotImplementedException;
        }
    }
}
