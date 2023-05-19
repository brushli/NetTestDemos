//==============================================================================
//	CAUTION: This file is generated by IBatisNetGen.DaoImpl.cst at 2013/8/2 17:13:38
//				Any manual editing will be lost in re-generation.
//==============================================================================
using System;
using System.Collections.Generic;
using System.Text;
using IBatisNet.DataMapper;
using WcfStatistics.Model;
using WcfStatistics.Dao.Int;

namespace WcfStatistics.Dao.Imp {
	
    /// <summary><c>WcfServerDao</c> is the implementation of <see cref="IWcfServerDao"/>.</summary>
    public partial class WcfServerDao : BaseDao, IWcfServerDao {

		/// <summary>Implements <see cref="IWcfServerDao.GetCount"/></summary>
		public int GetCount() {
			String stmtId = "WcfServer-GetCount";
			int result = Instance.QueryForObject<int>(stmtId, null);
			return result;
		}

		/// <summary>Implements <see cref="IWcfServerDao.Find"/></summary>
		public WcfServer Find(Int32 iD) {
			String stmtId = "WcfServer-Find";
			WcfServer result = Instance.QueryForObject<WcfServer>(stmtId, iD);
			return result;
		}

		/// <summary>Implements <see cref="IWcfServerDao.FindAll"/></summary>
		public IList<WcfServer> FindAll() {
			String stmtId = "WcfServer-FindAll";
			IList<WcfServer> result = Instance.QueryForList<WcfServer>(stmtId, null);
			return result;
		}
		
		/// <summary>Implements <see cref="IWcfServerDao.QuickFindAll"/></summary>
		public IList<WcfServer> QuickFindAll() {
			String stmtId = "WcfServer-QuickFindAll";
			IList<WcfServer> result = Instance.QueryForList<WcfServer>(stmtId, null);
			return result;
		}
		
		/// <summary>Implements <see cref="IWcfServerDao.FindByIP"/></summary>
		public IList<WcfServer> FindByIP(String iP) {
			String stmtId = "WcfServer-FindByIP";
			IList<WcfServer> result = Instance.QueryForList<WcfServer>(stmtId, iP);
			return result;
		}
		
		/// <summary>Implements <see cref="IWcfServerDao.FindByPoint"/></summary>
		public IList<WcfServer> FindByPoint(Int32? point) {
			String stmtId = "WcfServer-FindByPoint";
			IList<WcfServer> result = Instance.QueryForList<WcfServer>(stmtId, point);
			return result;
		}
		
		/// <summary>Implements <see cref="IWcfServerDao.FindByRemark"/></summary>
		public IList<WcfServer> FindByRemark(String remark) {
			String stmtId = "WcfServer-FindByRemark";
			IList<WcfServer> result = Instance.QueryForList<WcfServer>(stmtId, remark);
			return result;
		}
		
		/// <summary>Implements <see cref="IWcfServerDao.FindByCreateTime"/></summary>
		public IList<WcfServer> FindByCreateTime(DateTime? createTime) {
			String stmtId = "WcfServer-FindByCreateTime";
			IList<WcfServer> result = Instance.QueryForList<WcfServer>(stmtId, createTime);
			return result;
		}
		
		/// <summary>Implements <see cref="IWcfServerDao.Insert"/></summary>
		public void Insert(WcfServer obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "WcfServer-Insert";
			Instance.Insert(stmtId, obj);
		}
		
		/// <summary>Implements <see cref="IWcfServerDao.Update"/></summary>
		public void Update(WcfServer obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "WcfServer-Update";
			Instance.Update(stmtId, obj);
		}
		
		/// <summary>Implements <see cref="IWcfServerDao.Delete"/></summary>
		public void Delete(WcfServer obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "WcfServer-Delete";
			Instance.Delete(stmtId, obj);
		}
		
		/// <summary>Implements <see cref="IWcfServerDao.DeleteByIP"/></summary>
		public int DeleteByIP(String iP) {
			String stmtId = "WcfServer-DeleteByIP";
			int result = Instance.Delete(stmtId, iP);
			return result;
		}
		
		/// <summary>Implements <see cref="IWcfServerDao.DeleteByPoint"/></summary>
		public int DeleteByPoint(Int32? point) {
			String stmtId = "WcfServer-DeleteByPoint";
			int result = Instance.Delete(stmtId, point);
			return result;
		}
		
		/// <summary>Implements <see cref="IWcfServerDao.DeleteByRemark"/></summary>
		public int DeleteByRemark(String remark) {
			String stmtId = "WcfServer-DeleteByRemark";
			int result = Instance.Delete(stmtId, remark);
			return result;
		}
		
		/// <summary>Implements <see cref="IWcfServerDao.DeleteByCreateTime"/></summary>
		public int DeleteByCreateTime(DateTime? createTime) {
			String stmtId = "WcfServer-DeleteByCreateTime";
			int result = Instance.Delete(stmtId, createTime);
			return result;
		}
		
		/// <summary>Implements <see cref="IWcfServerDao.Reload"/></summary>
		public void Reload(WcfServer obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "WcfServer-Find";
			Instance.QueryForObject<WcfServer>(stmtId, obj, obj);
		}
		
	}

}
