﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Api.Net.Domain.Reports;
using MailChimp.Api.Net.Enum;
using Newtonsoft.Json;

namespace MailChimp.Api.Net.Services.Reports
{
    // ===================================================================================
    // AUTHOR      : Shahriar Hossain
    // PURPOSE     : Get a summary of social activity for the campaign, tracked by EepURL. 
    // ====================================================================================

    internal class MCReportsEepURL
    {
        /// <summary>
        /// Return a summary of social activity for the campaign, tracked by EepURL.
        /// <param name="campaignId">Unique id for campaign</param>
        /// </summary>
        internal async Task<Eepurl> GetEepUrlActivityAsync(string campaignId)
        {
            string endpoint = Authenticate.EndPoint(TargetTypes.reports, SubTargetType.eepurl, SubTargetType.not_applicable, campaignId);

            string content;
            using (var client = new HttpClient())
            {
                Authenticate.ClientAuthentication(client);

                content = await client.GetStringAsync(endpoint).ConfigureAwait(false);
            }

            return JsonConvert.DeserializeObject<Eepurl>(content);
        }
    }
}
