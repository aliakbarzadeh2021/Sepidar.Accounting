using System.Reflection;
using System.Resources;

namespace Sepidar.Message
{
    public class CustomMessage
    {
        static ResourceManager resourceManager;

        public static string GetMessage(string messageName, string language = "fa-IR")
        {
            if (resourceManager is null)
            {
                resourceManager = new ResourceManager("Sepidar.Message.Resources.ExceptionMessages", Assembly.GetExecutingAssembly());
            }

            return resourceManager.GetString(messageName, System.Globalization.CultureInfo.GetCultureInfo(language));
        }

        public static string DefaultMessage = GetMessage("DefaultMessage");
        public static string DuplicateRecordMessage = GetMessage("DuplicateRecordMessage");
        public static string GroupCodeLengthMessage = GetMessage("GroupCodeLengthMessage");
        public static string SubGroupCodeLengthMessage = GetMessage("SubGroupCodeLengthMessage");
        public static string NotFoundMessage = GetMessage("NotFoundMessage");
        public static string NotFoundSettingMessage = GetMessage("NotFoundSettingMessage");
        public static string PlateCodeLengthMessage = GetMessage("PlateCodeLengthMessage");
        public static string NotAllowedMessage = GetMessage("NotAllowedMessage");
        public static string DuplicateAssetDepreciationMethodMessage = GetMessage("DuplicateAssetDepreciationMethodMessage");
        public static string NotFoundAssetDepreciationMethodMessage = GetMessage("NotFoundAssetDepreciationMethodMessage");
        public static string DuplicateDepreciationRulesMessage = GetMessage("DuplicateDepreciationRulesMessage");
        public static string NotFoundDepreciationRulesMessage = GetMessage("NotFoundDepreciationRulesMessage");
        public static string DuplicateGroupMessage = GetMessage("DuplicateGroupMessage");
        public static string NotFoundGroupSettingMessage = GetMessage("NotFoundGroupSettingMessage");
        public static string NotFoundGroupMessage = GetMessage("NotFoundGroupMessage");
        public static string NotAllowedDeleteMessage = GetMessage("NotAllowedDeleteMessage");
        public static string NotFoundSubGroupMessage = GetMessage("NotFoundSubGroupMessage");
        public static string DuplicateSubGroupMessage = GetMessage("DuplicateSubGroupMessage");
        public static string DuplicateSubGroupDepreciationMethodMessage = GetMessage("DuplicateSubGroupDepreciationMethodMessage");
        public static string NotFoundSubGroupDepreciationMethodMessage = GetMessage("NotFoundSubGroupDepreciationMethodMessage");
        public static string DuplicateSubGroupPropertiesMessage = GetMessage("DuplicateSubGroupPropertiesMessage");
        public static string NotFoundSubGroupPropertiesMessage = GetMessage("NotFoundSubGroupPropertiesMessage");
        public static string NotFoundAssetMessage = GetMessage("NotFoundAssetMessage");
        public static string DuplicateAssetMessage = GetMessage("DuplicateAssetMessage");
        public static string NotFoundPlateSettingMessage = GetMessage("NotFoundPlateSettingMessage");
        public static string DuplicateGroupSettingMessage = GetMessage("DuplicateGroupSettingMessage");
        public static string DuplicatePlateSettingMessage = GetMessage("DuplicatePlateSettingMessage");
        public static string NotAllowedEditMessage = GetMessage("NotAllowedEditMessage");
        public static string NotAllowedDeleteAssetMessage = GetMessage("NotAllowedDeleteAssetMessage");
        public static string AssetIsActiveMessage = GetMessage("AssetIsActiveMessage");
        public static string AssetIsUnUseMessage = GetMessage("AssetIsUnUseMessage");
        public static string DuplicateGuaranteeMessage = GetMessage("DuplicateGuaranteeMessage");
        public static string DuplicateInsuranceMessage = GetMessage("DuplicateInsuranceMessage");
        public static string NotAllowedDeleteGuaranteeMessage = GetMessage("NotAllowedDeleteGuaranteeMessage");
        public static string NotAllowedDeleteGroupMessage = GetMessage("NotAllowedDeleteGroupMessage");
        public static string NotAllowedDeleteSubGroupMessage = GetMessage("NotAllowedDeleteSubGroupMessage");
        public static string NotAllowedDeleteSubGroupDepreciationMethodMessage = GetMessage("NotAllowedDeleteSubGroupDepreciationMethodMessage");
        public static string NotAllowedDeletePropertiesMessage = GetMessage("NotAllowedDeletePropertiesMessage");
        public static string DuplicateAcquisitionMessage = GetMessage("DuplicateAcquisitionMessage");

        public static string NotAllowedEditGroupMessage = GetMessage("NotAllowedEditGroupMessage");
        public static string NotAllowedEditSubGroupMessage = GetMessage("NotAllowedEditSubGroupMessage");
        public static string NotAllowedEditSubGroupDepreciationMethodMessage = GetMessage("NotAllowedEditSubGroupDepreciationMethodMessage");
        public static string NotAllowedEditPropertiesMessage = GetMessage("NotAllowedEditPropertiesMessage");
        public static string DuplicateAssetPlateNumberMessage = GetMessage("DuplicateAssetPlateNumberMessage");
        public static string DuplicateAssetOldPlateNumberMessage = GetMessage("DuplicateAssetOldPlateNumberMessage");

        public static string NotAllowedDeleteAcquisitedAssetMessage = GetMessage("NotAllowedDeleteAcquisitedAssetMessage");
        public static string NotAllowedDeleteActiveAssetMessage = GetMessage("NotAllowedDeleteActiveAssetMessage");
        public static string NotAllowedDeleteDepreciatedAssetMessage = GetMessage("NotAllowedDeleteDepreciatedAssetMessage");
        public static string NotAllowedDeleteRemovedAssetMessage = GetMessage("NotAllowedDeleteRemovedAssetMessage");
        public static string NotAllowedDeleteMissingAssetMessage = GetMessage("NotAllowedDeleteMissingAssetMessage");
        public static string NotAllowedDeleteScrappingAssetMessage = GetMessage("NotAllowedDeleteScrappingAssetMessage");
        public static string NotAllowedDeleteSelledAssetMessage = GetMessage("NotAllowedDeleteSelledAssetMessage");
        public static string NotAllowedDeleteUnUsedAssetMessage = GetMessage("NotAllowedDeleteUnUsedAssetMessage");

        public static string NotAllowedUnUsedAssetMessage = GetMessage("NotAllowedUnUsedAssetMessage");
        public static string NotAllowedReUseAssetMessage = GetMessage("NotAllowedReUseAssetMessage");
        //public static string NotAllowedAcquisitAssetMessage = GetMessage("NotAllowedAcquisitAssetMessage");
        public static string NotAllowedSellAssetMessage = GetMessage("NotAllowedSellAssetMessage");
        public static string NotAllowedScrappingAssetMessage = GetMessage("NotAllowedScrappingAssetMessage");
        public static string NotAllowedChangeDepreciationMethodMessage = GetMessage("NotAllowedChangeDepreciationMethodMessage");

        public static string NotAllowedReUseDateLessThanOperationDateMessage = GetMessage("NotAllowedReUseDateLessThanOperationDateMessage");
        public static string NotAllowedUnUseDateLessThanOperationDateMessage = GetMessage("NotAllowedUnUseDateLessThanOperationDateMessage");
        public static string NotAllowedScrappingDateLessThanOperationDateMessage = GetMessage("NotAllowedScrappingDateLessThanOperationDateMessage");
        public static string NotAllowedAssetRemoveDateLessThanOperationDateMessage = GetMessage("NotAllowedAssetRemoveDateLessThanOperationDateMessage");
        public static string NotAllowedSellDateLessThanOperationDateMessage = GetMessage("NotAllowedSellDateLessThanOperationDateMessage");
        public static string NotAllowedChangeDepreciationDateLessThanOperationDateMessage = GetMessage("NotAllowedChangeDepreciationDateLessThanOperationDateMessage");
        public static string NotAllowedReUseDateLessThanUnUseDateMessage = GetMessage("NotAllowedReUseDateLessThanUnUseDateMessage");
        public static string DuplicateSellAssetMessage = GetMessage("DuplicateSellAssetMessage");
        public static string DuplicateScrappingAssetMessage = GetMessage("DuplicateScrappingAssetMessage");
        public static string DuplicateRemoveAssetMessage = GetMessage("DuplicateRemoveAssetMessage");
        public static string AssetIsDepreciatedMessage = GetMessage("AssetIsDepreciatedMessage");

        public static string DuplicateAssetDepreciationCalculateMessage = GetMessage("DuplicateAssetDepreciationCalculateMessage");
        public static string NotAllowedTransferDateLessThanOperationDateMessage = GetMessage("NotAllowedTransferDateLessThanOperationDateMessage");
        public static string NotAllowedTransferDateLessThanOldTransferDateMessage = GetMessage("NotAllowedTransferDateLessThanOldTransferDateMessage");
        public static string DuplicateAssetTransferMessage = GetMessage("DuplicateAssetTransferMessage");
        public static string NotAllowedCopyAssetMessage = GetMessage("NotAllowedCopyAssetMessage");
        public static string NotAllowedDepreciationCalculateMessage = GetMessage("NotAllowedDepreciationCalculateMessage");
    }
}