﻿namespace SmartStore.Services.DataExchange.Import
{
	public partial interface IEntityImporter
	{
		void Execute(IImportExecuteContext context);
	}
}