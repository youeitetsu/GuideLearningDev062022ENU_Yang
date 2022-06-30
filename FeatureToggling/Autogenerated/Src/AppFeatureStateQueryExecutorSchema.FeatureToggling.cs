﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AppFeatureStateQueryExecutorSchema

	/// <exclude/>
	public class AppFeatureStateQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AppFeatureStateQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AppFeatureStateQueryExecutorSchema(AppFeatureStateQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2f78da26-bcd3-4e5f-a839-3a84fd950fc2");
			Name = "AppFeatureStateQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f56dd55e-5084-4296-932e-a32f081a1593");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,86,77,111,226,48,16,61,167,82,255,131,197,94,18,9,69,218,43,93,42,181,180,84,57,180,219,21,237,238,161,234,193,36,19,240,42,216,212,118,182,139,170,254,247,29,127,144,56,4,88,46,33,177,223,188,121,243,236,177,225,116,5,106,77,115,32,79,32,37,85,162,212,233,213,122,61,5,170,107,9,234,252,236,227,252,44,170,21,227,11,50,219,40,13,171,139,230,187,13,152,8,9,135,198,241,193,75,182,168,37,213,76,240,131,168,91,174,153,102,160,14,2,166,52,215,66,58,4,98,190,72,88,32,31,153,84,84,169,17,105,37,207,52,213,240,163,6,185,185,253,11,121,141,49,22,255,114,3,37,173,43,125,205,120,129,236,177,222,172,65,148,113,102,243,110,102,249,18,86,180,19,149,12,201,3,122,67,198,100,112,140,124,144,188,34,59,227,26,36,167,21,201,141,156,163,106,200,136,92,83,213,29,27,146,195,58,144,253,195,86,208,150,44,184,210,178,54,118,96,229,143,245,188,98,185,67,172,237,251,209,244,241,179,2,137,12,28,114,179,30,164,238,124,38,134,37,26,145,57,42,140,187,83,195,158,15,131,132,152,205,17,125,122,121,192,11,167,176,43,247,30,244,82,20,251,149,186,170,39,162,170,188,156,59,208,187,99,113,207,154,41,171,180,145,214,68,149,118,64,121,61,209,31,42,73,222,206,142,9,135,247,94,170,29,35,134,36,76,147,92,52,68,160,222,58,12,129,142,29,138,52,4,220,83,78,23,32,141,107,197,138,241,103,206,116,215,59,151,1,217,211,171,162,184,170,42,23,134,250,234,21,87,177,159,14,202,205,120,41,124,161,246,117,188,173,58,125,164,82,129,3,53,129,172,36,49,122,153,169,71,201,86,84,110,28,239,79,90,213,30,25,183,84,67,34,106,77,238,106,86,144,50,144,152,21,201,214,208,168,191,61,189,40,60,16,188,14,20,100,138,153,72,164,240,57,126,49,189,68,113,216,69,86,218,118,217,86,107,42,153,18,252,9,91,48,189,125,171,105,133,46,101,197,96,232,114,69,59,34,92,65,214,41,95,164,113,204,235,247,179,159,4,42,5,196,84,221,214,149,90,3,102,216,237,21,4,245,219,140,202,187,48,120,105,55,245,40,43,70,254,245,53,13,244,236,186,115,186,49,91,252,244,68,135,124,194,163,70,121,133,131,97,32,231,144,69,221,252,93,175,124,1,18,16,194,131,118,241,32,251,236,181,103,65,53,205,248,205,220,151,178,175,91,187,61,225,115,150,120,130,211,124,73,124,47,19,41,222,9,107,233,26,59,253,52,184,159,113,167,229,188,113,110,104,127,154,200,5,166,51,208,120,220,7,107,222,244,197,22,209,111,11,204,134,170,246,76,244,168,131,185,120,187,28,102,187,216,120,180,196,44,87,17,128,190,153,205,115,25,66,147,190,222,125,164,19,81,192,17,90,188,4,112,111,183,196,230,186,250,47,117,115,26,157,162,24,111,252,16,127,50,183,85,114,130,240,144,255,36,245,157,35,244,112,2,188,142,47,119,192,9,25,143,201,215,93,122,243,143,130,47,44,2,215,223,127,126,159,255,198,93,101,7,211,7,161,39,75,202,23,80,248,200,182,81,108,139,57,162,36,108,154,253,29,181,255,146,116,163,221,65,28,251,7,83,222,52,247,149,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f78da26-bcd3-4e5f-a839-3a84fd950fc2"));
		}

		#endregion

	}

	#endregion

}
