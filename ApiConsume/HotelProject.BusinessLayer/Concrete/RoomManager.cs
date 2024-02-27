using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
	public class RoomManager : IRoomService
	{
		private readonly IRoomDal _RoomDal;

		public RoomManager(IRoomDal RoomDal)
		{
			_RoomDal = RoomDal;
		}

		public void TDelete(Room t)
		{
			_RoomDal.Delete(t);
		}

		public Room TGetById(int id)
		{
			return _RoomDal.GetById(id);
		}

		public List<Room> TGetList()
		{
			return _RoomDal.GetList();
		}

		public void TInsert(Room t)
		{
			_RoomDal.Insert(t);
		}

		public void TUpdate(Room t)
		{
			_RoomDal.Update(t);
		}
	}
}
