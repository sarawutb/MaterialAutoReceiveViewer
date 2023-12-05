namespace Material_Auto_Receive_Viewer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Channels;

    public partial class MaterialReceiveModel
    {
        [JsonPropertyName("ARP_Material_Request_MST")]
        public ArpMaterialRequestMst ARP_Material_Request_MST { get; set; }

        [JsonPropertyName("ARP_Material_Request_MST_Reference")]
        public ArpMaterialRequestMstReference ArpMaterialRequestMstReference { get; set; }

        [JsonPropertyName("ARP_Receive_Plan_MST")]
        public ArpReceivePlanMst ArpReceivePlanMst { get; set; }

        [JsonPropertyName("LST_ARP_Receive_Plan_DTL")]
        public List<LstArpReceivePlanDtl> LstArpReceivePlanDtl { get; set; }

        [JsonPropertyName("LST_ARP_Receive_Plan_DTL_Barcode")]
        public List<LstArpReceivePlanDtlBarcode> LstArpReceivePlanDtlBarcode { get; set; }

        [JsonPropertyName("LST_ARP_Receive_Plan_DTL_Reference")]
        public List<LstArpReceivePlanDtlReference> LstArpReceivePlanDtlReference { get; set; }

        [JsonPropertyName("RM_Cust_INMST_External")]
        public RmCustInmstExternal RmCustInmstExternal { get; set; }

        [JsonPropertyName("RM_OTHER_OUTMST")]
        public RmOtherOutmst RmOtherOutmst { get; set; }

        [JsonPropertyName("RM_CUST_INMST_Owner")]
        public RmCustInmst RmCustInmstOwner { get; set; }

        [JsonPropertyName("RM_Cust_IN_OUT_Mapping_Owner")]
        public RmCustInOutMapping RmCustInOutMappingOwner { get; set; }

        [JsonPropertyName("LST_RM_Cust_IN_OUT_Barcode_Mapping_Owner")]
        public List<LstRmCustInOutBarcodeMapping> LstRmCustInOutBarcodeMappingOwner { get; set; }

        [JsonPropertyName("LST_RM_BAL_Owner")]
        public List<LstRmBal> LstRmBalOwner { get; set; }

        [JsonPropertyName("LST_RM_ALL_INDTL_EXT_Owner")]
        public List<LstRmAllIndtlExt> LstRmAllIndtlExtOwner { get; set; }

        [JsonPropertyName("LST_RM_CUST_INDTL_Owner")]
        public List<LstRmCustIndtl> LstRmCustIndtlOwner { get; set; }

        [JsonPropertyName("LST_RM_OTHER_OUTDTL")]
        public List<LstRmOtherOutdtl> LstRmOtherOutdtl { get; set; }

        [JsonPropertyName("LST_RM_OtherOut_Map_Report")]
        public List<LstRmOtherOutMapReport> LstRmOtherOutMapReport { get; set; }

        [JsonPropertyName("RM_CUST_INMST_Receive")]
        public RmCustInmst RmCustInmstReceive { get; set; }

        [JsonPropertyName("RM_Cust_IN_OUT_Mapping_Receive")]
        public RmCustInOutMapping RmCustInOutMappingReceive { get; set; }

        [JsonPropertyName("LST_RM_Cust_IN_OUT_Barcode_Mapping_Receive")]
        public List<LstRmCustInOutBarcodeMapping> LstRmCustInOutBarcodeMappingReceive { get; set; }

        [JsonPropertyName("LST_RM_BAL_Receive")]
        public List<LstRmBal> LstRmBalReceive { get; set; }

        [JsonPropertyName("LST_RM_CUST_INDTL_Receive")]
        public List<LstRmCustIndtl> LstRmCustIndtlReceive { get; set; }

        [JsonPropertyName("LST_RM_ALL_INDTL_EXT_Receive")]
        public List<LstRmAllIndtlExt> LstRmAllIndtlExtReceive { get; set; }
    }

    public partial class ArpMaterialRequestMst
    {
        [JsonPropertyName("ID")]
        public long id { get; set; }

        [JsonPropertyName("Revise_No")]
        public long ReviseNo { get; set; }

        [JsonPropertyName("Doc_No")]
        public string DocNo { get; set; }

        [JsonPropertyName("PO_No")]
        public string PoNo { get; set; }

        [JsonPropertyName("ARP_Supply_From_Type_ID")]
        public long ArpSupplyFromTypeId { get; set; }

        [JsonPropertyName("Supply_From_Code")]
        public string SupplyFromCode { get; set; }

        [JsonPropertyName("ARP_Supplier_Type_ID")]
        public long ArpSupplierTypeId { get; set; }

        [JsonPropertyName("ExpectDate")]
        public DateTime ExpectDate { get; set; }

        [JsonPropertyName("ARP_Material_Request_Status_ID")]
        public long ArpMaterialRequestStatusId { get; set; }

        [JsonPropertyName("ARP_Request_Purpose_ID")]
        public long ArpRequestPurposeId { get; set; }

        [JsonPropertyName("Owner_Site")]
        public long OwnerSite { get; set; }

        [JsonPropertyName("Operation_Site")]
        public long OperationSite { get; set; }

        [JsonPropertyName("Receive_Site")]
        public long ReceiveSite { get; set; }

        [JsonPropertyName("Transfer_To_Site")]
        public long TransferToSite { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("Return_Date")]
        public object ReturnDate { get; set; }

        [JsonPropertyName("Borrow_Doc_No")]
        public object BorrowDocNo { get; set; }

        [JsonPropertyName("Request_By")]
        public long RequestBy { get; set; }

        [JsonPropertyName("Request_Date")]
        public DateTime RequestDate { get; set; }

        [JsonPropertyName("Approved_By")]
        public long ApprovedBy { get; set; }

        [JsonPropertyName("Approved_Date")]
        public DateTime ApprovedDate { get; set; }

        [JsonPropertyName("Revise_By")]
        public long ReviseBy { get; set; }

        [JsonPropertyName("Revise_Date")]
        public DateTime ReviseDate { get; set; }
    }

    public partial class ArpMaterialRequestMstReference
    {
        [JsonPropertyName("ID")]
        public long Id { get; set; }

        [JsonPropertyName("Document_Reference_Type_Id")]
        public long DocumentReferenceTypeId { get; set; }

        [JsonPropertyName("Document_Reference_Value")]
        public string DocumentReferenceValue { get; set; }

        [JsonPropertyName("ARP_Mateiral_Request_MST_ID")]
        public long ArpMateiralRequestMstId { get; set; }

        [JsonPropertyName("Site_ID")]
        public long SiteId { get; set; }

        [JsonPropertyName("ARP_Item_Group_ID")]
        public long ArpItemGroupId { get; set; }

        [JsonPropertyName("Create_Date")]
        public DateTime CreateDate { get; set; }

        [JsonPropertyName("ARP_Document_Reference_Type")]
        public object ArpDocumentReferenceType { get; set; }
    }

    public partial class ArpReceivePlanMst
    {
        [JsonPropertyName("ID")]
        public long Id { get; set; }

        [JsonPropertyName("Revise_No")]
        public long ReviseNo { get; set; }

        [JsonPropertyName("ARP_Material_Request_MST_ID")]
        public long ArpMaterialRequestMstId { get; set; }

        [JsonPropertyName("ARP_Receive_Plan_MST_Status_ID")]
        public long ArpReceivePlanMstStatusId { get; set; }

        [JsonPropertyName("ARP_Supplier_Type_ID")]
        public long ArpSupplierTypeId { get; set; }

        [JsonPropertyName("Owner_Site")]
        public long OwnerSite { get; set; }

        [JsonPropertyName("Operation_Site")]
        public long OperationSite { get; set; }

        [JsonPropertyName("Receiving_Site")]
        public long ReceivingSite { get; set; }

        [JsonPropertyName("Request_Receiving_Date")]
        public DateTime RequestReceivingDate { get; set; }

        [JsonPropertyName("Revise_By")]
        public long ReviseBy { get; set; }

        [JsonPropertyName("Revise_Date")]
        public DateTime ReviseDate { get; set; }
    }

    public partial class LstArpReceivePlanDtl
    {
        [JsonPropertyName("ID")]
        public long Id { get; set; }

        [JsonPropertyName("ARP_Receive_Plan_MST_ID")]
        public long ArpReceivePlanMstId { get; set; }

        [JsonPropertyName("ARP_Material_Request_DTL_ID")]
        public long ArpMaterialRequestDtlId { get; set; }

        [JsonPropertyName("RM_ID")]
        public string RmId { get; set; }

        [JsonPropertyName("Plan_Receive_Weight")]
        public double PlanReceiveWeight { get; set; }

        [JsonPropertyName("ARP_Receive_Plan_DTL_Status_ID")]
        public double ArpReceivePlanDtlStatusId { get; set; }

        [JsonPropertyName("Remark")]
        public object Remark { get; set; }

        [JsonPropertyName("Revise_By")]
        public long ReviseBy { get; set; }

        [JsonPropertyName("Revise_Date")]
        public DateTime ReviseDate { get; set; }

        [JsonPropertyName("KEYLINK")]
        public object Keylink { get; set; }

        [JsonPropertyName("LIST_NO")]
        public object ListNo { get; set; }
    }

    public partial class LstArpReceivePlanDtlBarcode
    {
        [JsonPropertyName("ID")]
        public long Id { get; set; }

        [JsonPropertyName("ARP_Receive_Plan_DTL_ID")]
        public long ArpReceivePlanDtlId { get; set; }

        [JsonPropertyName("RM_ID")]
        public string RmId { get; set; }

        [JsonPropertyName("Barcode")]
        public string Barcode { get; set; }

        [JsonPropertyName("Batch_No")]
        public object BatchNo { get; set; }

        [JsonPropertyName("PI_Lot_No")]
        public string PiLotNo { get; set; }

        [JsonPropertyName("Lot_No")]
        public string LotNo { get; set; }

        [JsonPropertyName("Qty")]
        public double Qty { get; set; }

        [JsonPropertyName("ARP_Receive_Plan_DTL_Barcode_Status_ID")]
        public long ArpReceivePlanDtlBarcodeStatusId { get; set; }

        [JsonPropertyName("Status_QA")]
        public bool StatusQa { get; set; }

        [JsonPropertyName("Receiving_By")]
        public long ReceivingBy { get; set; }

        [JsonPropertyName("Receiving_Date")]
        public DateTime ReceivingDate { get; set; }

        [JsonPropertyName("Revise_By")]
        public long ReviseBy { get; set; }

        [JsonPropertyName("Revise_Date")]
        public DateTime ReviseDate { get; set; }

        [JsonPropertyName("ARP_Receive_Plan_Recheck_Cause")]
        public long ArpReceivePlanRecheckCause { get; set; }
    }

    public partial class LstArpReceivePlanDtlReference
    {
        [JsonPropertyName("ID")]
        public long Id { get; set; }

        [JsonPropertyName("Document_Reference_Value")]
        public string DocumentReferenceValue { get; set; }

        [JsonPropertyName("ARP_Receive_Plan_Dtl_ID")]
        public long ArpReceivePlanDtlId { get; set; }

        [JsonPropertyName("Site_ID")]
        public long SiteId { get; set; }

        [JsonPropertyName("Create_Date")]
        public DateTime CreateDate { get; set; }

        [JsonPropertyName("Lot_No")]
        public string LotNo { get; set; }

        [JsonPropertyName("PI_Lot_No")]
        public string PiLotNo { get; set; }
    }

    public partial class LstRmAllIndtlExt
    {
        [JsonPropertyName("DOC_ID")]
        public string DocId { get; set; }

        [JsonPropertyName("IN_ID")]
        public string InId { get; set; }

        [JsonPropertyName("RM_ID")]
        public string RmId { get; set; }

        [JsonPropertyName("PI_LOT_NO")]
        public string PiLotNo { get; set; }

        [JsonPropertyName("First_REC_DATE")]
        
        public string FirstRecDate { get; set; }
    }

    public partial class LstRmBal
    {
        [JsonPropertyName("IN_ID")]
        public string InId { get; set; }

        [JsonPropertyName("RM_ID")]
        public string RmId { get; set; }

        [JsonPropertyName("PI_LOT_NO")]
        public string PiLotNo { get; set; }

        [JsonPropertyName("BARCODE")]
        public string Barcode { get; set; }

        [JsonPropertyName("LOT_NO")]
        public string LotNo { get; set; }

        [JsonPropertyName("TYPE")]
        public string Type { get; set; }

        [JsonPropertyName("QTY")]
        public double Qty { get; set; }

        [JsonPropertyName("REC_DATE")]
        
        public string RecDate { get; set; }

        [JsonPropertyName("EXP_DATE")]
        
        public string ExpDate { get; set; }

        [JsonPropertyName("LOC_CODE")]
        public object LocCode { get; set; }

        [JsonPropertyName("CHANGE_QTY")]
        public object ChangeQty { get; set; }

        [JsonPropertyName("LATELY_USEDATE")]
        public string LatelyUsedate { get; set; }

        [JsonPropertyName("LATELY_USETIME")]
        public string LatelyUsetime { get; set; }

        [JsonPropertyName("LOCK")]
        
        public string Lock { get; set; }

        [JsonPropertyName("PRINT_BC")]
        public string PrintBc { get; set; }

        [JsonPropertyName("IN_ID_COST")]
        public object InIdCost { get; set; }

        [JsonPropertyName("KEY_TYPE")]
        public object KeyType { get; set; }

        [JsonPropertyName("Location")]
        public object Location { get; set; }

        [JsonPropertyName("Site_ID")]
        public long SiteId { get; set; }

        [JsonPropertyName("WH_ID")]
        public object WhId { get; set; }

        [JsonPropertyName("LOCATION_ID")]
        public object LocationId { get; set; }

        [JsonPropertyName("IsTransfer_Use")]
        public object IsTransferUse { get; set; }

        [JsonPropertyName("QA_LOCK")]
        
        public string QaLock { get; set; }

        [JsonPropertyName("WH_LOCK")]
        public bool WhLock { get; set; }

        [JsonPropertyName("WH_REC_NUM")]
        public long WhRecNum { get; set; }

        [JsonPropertyName("WH_REC_DATE")]
        public DateTime WhRecDate { get; set; }

        [JsonPropertyName("WH_REC_USER")]
        public string WhRecUser { get; set; }

        [JsonPropertyName("REMARK_QA_LOCK")]
        public object RemarkQaLock { get; set; }

        [JsonPropertyName("REMARK_WH_LOCK")]
        public object RemarkWhLock { get; set; }

        [JsonPropertyName("Owner_Site_ID")]
        public long OwnerSiteId { get; set; }
    }

    public partial class LstRmCustInOutBarcodeMapping
    {
        [JsonPropertyName("RM_Cust_IN_OUT_Mapping_ID")]
        public long RmCustInOutMappingId { get; set; }

        [JsonPropertyName("RM_ID_Site")]
        public string RmIdSite { get; set; }

        [JsonPropertyName("BARCODE_Site")]
        public string BarcodeSite { get; set; }

        [JsonPropertyName("RM_ID_Owner")]
        public string RmIdOwner { get; set; }

        [JsonPropertyName("BARCODE_Owner")]
        public string BarcodeOwner { get; set; }
    }

    public partial class LstRmCustIndtl
    {
        [JsonPropertyName("DOC_ID")]
        public string DocId { get; set; }

        [JsonPropertyName("IN_ID")]
        public string InId { get; set; }

        [JsonPropertyName("RM_ID")]
        public string RmId { get; set; }

        [JsonPropertyName("PRODUCTION_DATE")]
        
        public string ProductionDate { get; set; }

        [JsonPropertyName("PI_LOT_NO")]
        public string PiLotNo { get; set; }

        [JsonPropertyName("LOT_NO")]
        public string LotNo { get; set; }

        [JsonPropertyName("CONT_QTY")]
        public double ContQty { get; set; }

        [JsonPropertyName("UNIT_CODE")]
        public string UnitCode { get; set; }

        [JsonPropertyName("CONT_WEIGHT")]
        public double ContWeight { get; set; }

        [JsonPropertyName("WEIGHT")]
        public double Weight { get; set; }
    }

    public partial class LstRmOtherOutMapReport
    {
        [JsonPropertyName("OUT_ID")]
        public string OutId { get; set; }

        [JsonPropertyName("BARCODE")]
        public string Barcode { get; set; }

        [JsonPropertyName("UNIT_CODE")]
        public string UnitCode { get; set; }

        [JsonPropertyName("UNIT_QTY")]
        public long UnitQty { get; set; }

        [JsonPropertyName("RESIDUE")]
        public object Residue { get; set; }
    }

    public partial class LstRmOtherOutdtl
    {
        [JsonPropertyName("OUT_ID")]
        public string OutId { get; set; }

        [JsonPropertyName("BARCODE")]
        public string Barcode { get; set; }

        [JsonPropertyName("BATCH_NO")]
        
        public string BatchNo { get; set; }

        [JsonPropertyName("BATCH_FORMULATION")]
        
        public string BatchFormulation { get; set; }

        [JsonPropertyName("RM_ID")]
        public string RmId { get; set; }

        [JsonPropertyName("Site_ID")]
        public long SiteId { get; set; }

        [JsonPropertyName("WEIGHT")]
        public double Weight { get; set; }

        [JsonPropertyName("FORMULAR")]
        public object Formular { get; set; }

        [JsonPropertyName("FORM_LOTNO")]
        public object FormLotno { get; set; }

        [JsonPropertyName("RETURN_DATE")]
        public object ReturnDate { get; set; }

        [JsonPropertyName("REMARK")]
        public object Remark { get; set; }

        [JsonPropertyName("KEY_LINK")]
        public object KeyLink { get; set; }
    }

    public partial class RmCustInOutMapping
    {
        [JsonPropertyName("ID")]
        public long Id { get; set; }

        [JsonPropertyName("IN_ID_Site")]
        public string InIdSite { get; set; }

        [JsonPropertyName("Operation_Site")]
        public long OperationSite { get; set; }

        [JsonPropertyName("IN_ID_Owner")]
        public string InIdOwner { get; set; }

        [JsonPropertyName("OUT_ID_Owner")]
        public string OutIdOwner { get; set; }

        [JsonPropertyName("Owner_Site")]
        public long OwnerSite { get; set; }

        [JsonPropertyName("Create_Date")]
        public DateTime CreateDate { get; set; }

        [JsonPropertyName("Com_Ext_Mapping_Type_Ref_ID")]
        public long ComExtMappingTypeRefId { get; set; }
    }

    public partial class RmCustInmstExternal
    {
        [JsonPropertyName("IN_ID")]
        public string InId { get; set; }

        [JsonPropertyName("PO_REF_NO")]
        public string PoRefNo { get; set; }

        [JsonPropertyName("INV_REF_NO")]
        public object InvRefNo { get; set; }

        [JsonPropertyName("CUSTOMER_ID_Real")]
        public object CustomerIdReal { get; set; }
    }

    public partial class RmCustInmst
    {
        [JsonPropertyName("DOC_ID")]
        public string DocId { get; set; }

        [JsonPropertyName("IN_ID")]
        public string InId { get; set; }

        [JsonPropertyName("REC_DATE")]
        
        public string RecDate { get; set; }

        [JsonPropertyName("REC_TIME")]
        
        public string RecTime { get; set; }

        [JsonPropertyName("OWNER_CODE")]
        public string OwnerCode { get; set; }

        [JsonPropertyName("SUPP_CODE")]
        public string SuppCode { get; set; }

        [JsonPropertyName("DOC_REF_NO")]
        public string DocRefNo { get; set; }

        [JsonPropertyName("TYPE")]
        public string Type { get; set; }

        [JsonPropertyName("FLAG")]
        public string Flag { get; set; }

        [JsonPropertyName("CANCEL")]
        public string Cancel { get; set; }

        [JsonPropertyName("KEY_TYPE")]
        public object KeyType { get; set; }

        [JsonPropertyName("REV_DATE")]
        public object RevDate { get; set; }

        [JsonPropertyName("REV_TIME")]
        public object RevTime { get; set; }

        [JsonPropertyName("ACC_DATE")]
        
        public string AccDate { get; set; }

        [JsonPropertyName("DOC_DATE")]
        
        public string DocDate { get; set; }

        [JsonPropertyName("REMARK1")]
        public string Remark1 { get; set; }

        [JsonPropertyName("REMARK2")]
        public object Remark2 { get; set; }

        [JsonPropertyName("LOCK")]
        public bool Lock { get; set; }
    }

    public partial class RmOtherOutmst
    {
        [JsonPropertyName("OUT_ID")]
        public string OutId { get; set; }

        [JsonPropertyName("DOC_NO")]
        public string DocNo { get; set; }

        [JsonPropertyName("DRAW_DATE")]
        
        public string DrawDate { get; set; }

        [JsonPropertyName("DRAW_TIME")]
        
        public string DrawTime { get; set; }

        [JsonPropertyName("DEPT_CODE")]
        public string DeptCode { get; set; }

        [JsonPropertyName("PURP_CODE")]
        public string PurpCode { get; set; }

        [JsonPropertyName("ALLOW")]
        public string Allow { get; set; }

        [JsonPropertyName("CANCEL")]
        public string Cancel { get; set; }

        [JsonPropertyName("RM_COST")]
        public object RmCost { get; set; }

        [JsonPropertyName("DRAW_TYPE")]
        public object DrawType { get; set; }

        [JsonPropertyName("REMARK")]
        public string Remark { get; set; }

        [JsonPropertyName("DDATE")]
        public object Ddate { get; set; }

        [JsonPropertyName("FORCODE")]
        public object Forcode { get; set; }

        [JsonPropertyName("CUSTOMER")]
        public object Customer { get; set; }

        [JsonPropertyName("BATCH")]
        public object Batch { get; set; }

        [JsonPropertyName("LEAVINGS")]
        public object Leavings { get; set; }

        [JsonPropertyName("ACC_DATE")]
        public string AccDate { get; set; }

        [JsonPropertyName("FM_CODE")]
        public object FmCode { get; set; }

        [JsonPropertyName("KEY_TYPE")]
        public object KeyType { get; set; }

        [JsonPropertyName("REV_DATE")]
        public object RevDate { get; set; }

        [JsonPropertyName("REV_TIME")]
        public object RevTime { get; set; }

        [JsonPropertyName("LOCK")]
        public bool Lock { get; set; }

        [JsonPropertyName("KEY_LINK")]
        public object KeyLink { get; set; }

        [JsonPropertyName("REMARK2")]
        public object Remark2 { get; set; }

        [JsonPropertyName("CUSTOMER_ID")]
        public object CustomerId { get; set; }

        [JsonPropertyName("Owner_Site_ID")]
        public long OwnerSiteId { get; set; }

        [JsonPropertyName("IsCompound_NG")]
        public bool IsCompoundNg { get; set; }

        [JsonPropertyName("IsResidue_Compound")]
        public bool IsResidueCompound { get; set; }
    }
}
