﻿using System.Net.Http;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Lists;
using MailChimp.Api.Net.Enum;

namespace MailChimp.Api.Net.Services.Lists
{
  // ================================================================================================
  // AUTHOR      : Shahriar Hossain
  // PURPOSE     : MailChimp list is a powerful and flexible tool that helps you manage your contacts
  // ================================================================================================

  public class MailChimpList
  {
    private MCListsAbuseReports listAbuseReport;
    private MCListsActivity listActivity;
    private MCListsClient listClient;
    private MCListsGrowthHistory listGrowthHistory;
    private MCListsMembers listMembers;
    private MCListsMergeFields listMergeFields;
    private MCListsOverview listOverview;
    private MCListsSegments listSegments;

    public MailChimpList()
    {
      listAbuseReport = new MCListsAbuseReports();
      listActivity = new MCListsActivity();
      listClient = new MCListsClient();
      listGrowthHistory = new MCListsGrowthHistory();

      listMembers = new MCListsMembers();
      listMergeFields = new MCListsMergeFields();
      listOverview = new MCListsOverview();
      listSegments = new MCListsSegments();
    }

    #region AbuseReport

    /// <summary>
    /// Get information about abuse reports
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<RootAbuseReport> GetAbuseReports(string list_id)
    {
      return await listAbuseReport.GetAbuseReports(list_id);
    }


    /// <summary>
    /// Get details about a specific abuse report
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="report_id">Id for the abuse report</param>
    /// </summary>
    public async Task<AbuseReport> GetAbuseReport(string list_id, string report_id)
    {
      return await listAbuseReport.GetAbuseReport(list_id, report_id);
    }

    #endregion AbuseReport

    #region Activity

    /// <summary>
    /// Get recent list activity
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<RootListsActivity> GetRecentActivity(string list_id)
    {
      return await listActivity.GetRecentActivity(list_id);
    }

    #endregion Activity

    #region Client

    /// <summary>
    /// Get top email clients
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<RootListsClient> GetTopEmailClients(string list_id)
    {
      return await listClient.GetTopEmailClients(list_id);
    }

    #endregion Client

    #region GrowthHistory

    /// <summary>
    /// Get list growth history data
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<RootListsGrowthHistory> GetGrowthHistory(string list_id)
    {
      return await listGrowthHistory.GetGrowthHistory(list_id);
    }

    /// <summary>
    /// Get list growth history by month
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="month">A specific month of list growth history.</param>
    /// </summary>
    public async Task<RootListsGrowth> GetGrowthHistoryByMonth(string list_id, string month)
    {
      return await listGrowthHistory.GetGrowthHistoryByMonth(list_id, month);
    }

    #endregion GrowthHistory

    #region Members

    /// <summary>
    /// Add a new list member
    /// <param name="member">Member to be added to the list</param>  
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<dynamic> AddMember(MCMember member, string list_id)
    {
      return await listMembers.AddMember(member, list_id);
    }

    /// <summary>
    /// Update a list member
    /// <param name="member">Member to be updated in the list</param> 
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<dynamic> UpdateMember(MCMember member, string list_id)
    {
      return await listMembers.UpdateMember(member, list_id);
    }

    /// <summary>
    /// Get information about members in a list
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<RootMember> GetAllMemberInfo(string list_id, int offset = 0, int count = 10)
    {
      return await listMembers.GetMemberInfoOfAList(list_id, offset, count);
    }

    /// <summary>
    /// Get information about a specific list member
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
    /// </summary>
    public async Task<MCMember> GetMemberInfo(string list_id, string subscriber_hash)
    {
      return await listMembers.GetMemberInfo(list_id, subscriber_hash);
    }

    /// <summary>
    /// Delete a list member
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="subscriber_hash">The MD5 hash of the lowercase version of the list member’s email address</param>
    /// </summary>
    public async Task<HttpResponseMessage> DeleteMember(string list_id, string subscriber_hash)
    {
      return await listMembers.DeleteMember(list_id, subscriber_hash);
    }

    #endregion Members

    #region MergeFields

    /// <summary>
    /// Add a new list merge field
    /// <param name="mergeField">The name of the merge field.</param>
    /// </summary>
    public async Task<dynamic> AddMergeField(MergeField mergeField, string list_id)
    {
      return await listMergeFields.AddMergeField(mergeField, list_id);
    }

    /// <summary>
    /// Update a list merge field
    /// <param name="mergeField">Merge field to update</param>
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<dynamic> UpdateMergeField(MergeField mergeField, string list_id)
    {
      return await listMergeFields.UpdateMergeField(mergeField, list_id);
    }

    /// <summary>
    /// Get all merge fields for a list
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<RootMergeField> GetAllMergeFields(string list_id)
    {
      return await listMergeFields.GetAllMergeFields(list_id);
    }

    /// <summary>
    /// Get a specific merge field
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="merge_id">The id for the merge field</param>
    /// </summary>
    public async Task<MergeField> GetMergeField(string list_id, string merge_id)
    {
      return await listMergeFields.GetMergeField(list_id, merge_id);
    }

    /// <summary>
    /// Delete a merge field
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="merge_id">The id for the merge field</param>
    /// </summary>
    public async Task<HttpResponseMessage> DeleteMergeField(string list_id, string merge_id)
    {
      return await listMergeFields.DeleteMergeField(list_id, merge_id);
    }

    #endregion MergeFields

    #region Overview

    /// <summary>
    /// Get information about all lists
    /// </summary>
    public async Task<RootMCLists> GetAllLists(int offset = 0, int count = 10)
    {
      return await listOverview.GetAllLists(offset, count);
    }

    /// <summary>
    /// Get information about a specific list
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<MCLists> GetList(string list_id)
    {
      return await listOverview.GetList(list_id);
    }

    /// <summary>
    /// Delete a list
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<HttpResponseMessage> DeleteList(string list_id)
    {
      return await listOverview.DeleteList(list_id);
    }

    /// <summary>
    /// Create a new list
    /// <param name="listName">The name of the list </param>
    /// <param name="contactForCampaignFotter">Contact information displayed in campaign footers to comply with international spam laws</param>
    /// <param name="permissionReminderText">The permission reminder for the list</param>
    /// <param name="defaultValue">Default values for campaigns created for this list</param>
    /// <param name="emailTypeOption">Whether the list supports multiple formats for emails.</param>
    /// <param name="listVisibility">Whether this list is public or private</param>
    /// </summary>
    public async Task<dynamic> CreateList(string listName, Contact contactForCampaignFotter,
                                          string permissionReminderText, CampaignDefaults defaultValue,
                                          bool emailTypeOption = false,
                                          ListVisibility listVisibility = ListVisibility.pub)
    {
      return
        await
        listOverview.CreateList(listName, contactForCampaignFotter, permissionReminderText, defaultValue,
                                emailTypeOption, listVisibility);
    }

    /// <summary>
    /// Update a list
    /// <param name="list_id">Unique id for the list</param> 
    /// <param name="listName">The name of the list </param>
    /// <param name="contactForCampaignFotter">Contact information displayed in campaign footers to comply with international spam laws</param>
    /// <param name="permissionReminderText">The permission reminder for the list</param>
    /// <param name="defaultValue">Default values for campaigns created for this list</param>
    /// <param name="emailTypeOption">Whether the list supports multiple formats for emails.</param>
    /// <param name="listVisibility">Whether this list is public or private</param>
    /// </summary>
    public async Task<dynamic> UpdateList(string list_id, string listName, Contact contactForCampaignFotter,
                                          string permissionReminderText, CampaignDefaults defaultValue,
                                          bool emailTypeOption = false,
                                          ListVisibility listVisibility = ListVisibility.pub)
    {
      return
        await
        listOverview.UpdateList(list_id, listName, contactForCampaignFotter, permissionReminderText, defaultValue,
                                emailTypeOption, listVisibility);
    }

    #endregion Overview

    #region Segments

    /// <summary>
    /// Get information about all segments in a list
    /// <param name="list_id">Unique id for the list</param>
    /// </summary>
    public async Task<RootSegment> GetAllSegment(string list_id)
    {
      return await listSegments.GetAllSegments(list_id);
    }

    /// <summary>
    /// Get information about a specific segment
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="segment_id">Unique id for the segment</param>
    /// </summary>
    public async Task<RootSegment> GetSegmentInfo(string list_id, string segment_id)
    {
      return await listSegments.GetSegmentInfo(list_id, segment_id);
    }

    /// <summary>
    /// Delete a segment
    /// <param name="list_id">Unique id for the list</param>
    /// <param name="segment_id">The segment id to delete</param>
    /// </summary>
    public async Task<HttpResponseMessage> DeleteSegment(string list_id, string segment_id)
    {
      return await listSegments.DeleteSegment(list_id, segment_id);
    }

    #endregion Segments
  }
}