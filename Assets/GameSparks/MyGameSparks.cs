#pragma warning disable 612,618
#pragma warning disable 0114
#pragma warning disable 0108

using System;
using System.Collections.Generic;
using GameSparks.Core;
using GameSparks.Api.Requests;
using GameSparks.Api.Responses;

//THIS FILE IS AUTO GENERATED, DO NOT MODIFY!!
//THIS FILE IS AUTO GENERATED, DO NOT MODIFY!!
//THIS FILE IS AUTO GENERATED, DO NOT MODIFY!!

namespace GameSparks.Api.Requests{
		public class LogEventRequest_acceptFriendRequest : GSTypedRequest<LogEventRequest_acceptFriendRequest, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_acceptFriendRequest() : base("LogEventRequest"){
			request.AddString("eventKey", "acceptFriendRequest");
		}
		
		public LogEventRequest_acceptFriendRequest Set_userId( string value )
		{
			request.AddString("userId", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_acceptFriendRequest : GSTypedRequest<LogChallengeEventRequest_acceptFriendRequest, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_acceptFriendRequest() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "acceptFriendRequest");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_acceptFriendRequest SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_acceptFriendRequest Set_userId( string value )
		{
			request.AddString("userId", value);
			return this;
		}
	}
	
	public class LogEventRequest_AddCurrency : GSTypedRequest<LogEventRequest_AddCurrency, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_AddCurrency() : base("LogEventRequest"){
			request.AddString("eventKey", "AddCurrency");
		}
		public LogEventRequest_AddCurrency Set_Value( long value )
		{
			request.AddNumber("Value", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_AddCurrency : GSTypedRequest<LogChallengeEventRequest_AddCurrency, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_AddCurrency() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "AddCurrency");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_AddCurrency SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_AddCurrency Set_Value( long value )
		{
			request.AddNumber("Value", value);
			return this;
		}			
	}
	
	public class LogEventRequest_Addlife : GSTypedRequest<LogEventRequest_Addlife, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_Addlife() : base("LogEventRequest"){
			request.AddString("eventKey", "Addlife");
		}
		
		public LogEventRequest_Addlife Set_player_id( string value )
		{
			request.AddString("player_id", value);
			return this;
		}
		
		public LogEventRequest_Addlife Set_group( string value )
		{
			request.AddString("group", value);
			return this;
		}
		
		public LogEventRequest_Addlife Set_message( string value )
		{
			request.AddString("message", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_Addlife : GSTypedRequest<LogChallengeEventRequest_Addlife, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_Addlife() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "Addlife");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_Addlife SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_Addlife Set_player_id( string value )
		{
			request.AddString("player_id", value);
			return this;
		}
		public LogChallengeEventRequest_Addlife Set_group( string value )
		{
			request.AddString("group", value);
			return this;
		}
		public LogChallengeEventRequest_Addlife Set_message( string value )
		{
			request.AddString("message", value);
			return this;
		}
	}
	
	public class LogEventRequest_addurlplayer : GSTypedRequest<LogEventRequest_addurlplayer, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_addurlplayer() : base("LogEventRequest"){
			request.AddString("eventKey", "addurlplayer");
		}
		
		public LogEventRequest_addurlplayer Set_url( string value )
		{
			request.AddString("url", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_addurlplayer : GSTypedRequest<LogChallengeEventRequest_addurlplayer, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_addurlplayer() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "addurlplayer");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_addurlplayer SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_addurlplayer Set_url( string value )
		{
			request.AddString("url", value);
			return this;
		}
	}
	
	public class LogEventRequest_allplayers : GSTypedRequest<LogEventRequest_allplayers, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_allplayers() : base("LogEventRequest"){
			request.AddString("eventKey", "allplayers");
		}
		public LogEventRequest_allplayers Set_GHOST_DATA( GSData value )
		{
			request.AddObject("GHOST_DATA", value);
			return this;
		}			
		
		public LogEventRequest_allplayers Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
		public LogEventRequest_allplayers Set_TIME( long value )
		{
			request.AddNumber("TIME", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_allplayers : GSTypedRequest<LogChallengeEventRequest_allplayers, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_allplayers() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "allplayers");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_allplayers SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_allplayers Set_GHOST_DATA( GSData value )
		{
			request.AddObject("GHOST_DATA", value);
			return this;
		}
		
		public LogChallengeEventRequest_allplayers Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
		public LogChallengeEventRequest_allplayers Set_TIME( long value )
		{
			request.AddNumber("TIME", value);
			return this;
		}			
	}
	
	public class LogEventRequest_AttributesNews : GSTypedRequest<LogEventRequest_AttributesNews, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_AttributesNews() : base("LogEventRequest"){
			request.AddString("eventKey", "AttributesNews");
		}
		
		public LogEventRequest_AttributesNews Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_AttributesNews : GSTypedRequest<LogChallengeEventRequest_AttributesNews, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_AttributesNews() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "AttributesNews");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_AttributesNews SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_AttributesNews Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_boosterSave : GSTypedRequest<LogEventRequest_boosterSave, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_boosterSave() : base("LogEventRequest"){
			request.AddString("eventKey", "boosterSave");
		}
		public LogEventRequest_boosterSave Set_GHOST_DATA( GSData value )
		{
			request.AddObject("GHOST_DATA", value);
			return this;
		}			
		
		public LogEventRequest_boosterSave Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
		public LogEventRequest_boosterSave Set_TIME( long value )
		{
			request.AddNumber("TIME", value);
			return this;
		}			
		
		public LogEventRequest_boosterSave Set_Idcurrent( string value )
		{
			request.AddString("Idcurrent", value);
			return this;
		}
		
		public LogEventRequest_boosterSave Set_boostDropdown( string value )
		{
			request.AddString("boostDropdown", value);
			return this;
		}
		
		public LogEventRequest_boosterSave Set_boostInput( string value )
		{
			request.AddString("boostInput", value);
			return this;
		}
		
		public LogEventRequest_boosterSave Set_Coins( string value )
		{
			request.AddString("Coins", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_boosterSave : GSTypedRequest<LogChallengeEventRequest_boosterSave, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_boosterSave() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "boosterSave");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_boosterSave SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_boosterSave Set_GHOST_DATA( GSData value )
		{
			request.AddObject("GHOST_DATA", value);
			return this;
		}
		
		public LogChallengeEventRequest_boosterSave Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
		public LogChallengeEventRequest_boosterSave Set_TIME( long value )
		{
			request.AddNumber("TIME", value);
			return this;
		}			
		public LogChallengeEventRequest_boosterSave Set_Idcurrent( string value )
		{
			request.AddString("Idcurrent", value);
			return this;
		}
		public LogChallengeEventRequest_boosterSave Set_boostDropdown( string value )
		{
			request.AddString("boostDropdown", value);
			return this;
		}
		public LogChallengeEventRequest_boosterSave Set_boostInput( string value )
		{
			request.AddString("boostInput", value);
			return this;
		}
		public LogChallengeEventRequest_boosterSave Set_Coins( string value )
		{
			request.AddString("Coins", value);
			return this;
		}
	}
	
	public class LogEventRequest_ChangeNameEvent : GSTypedRequest<LogEventRequest_ChangeNameEvent, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_ChangeNameEvent() : base("LogEventRequest"){
			request.AddString("eventKey", "ChangeNameEvent");
		}
		
		public LogEventRequest_ChangeNameEvent Set_Name( string value )
		{
			request.AddString("Name", value);
			return this;
		}
		public LogEventRequest_ChangeNameEvent Set_changecount( long value )
		{
			request.AddNumber("changecount", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_ChangeNameEvent : GSTypedRequest<LogChallengeEventRequest_ChangeNameEvent, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_ChangeNameEvent() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "ChangeNameEvent");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_ChangeNameEvent SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_ChangeNameEvent Set_Name( string value )
		{
			request.AddString("Name", value);
			return this;
		}
		public LogChallengeEventRequest_ChangeNameEvent Set_changecount( long value )
		{
			request.AddNumber("changecount", value);
			return this;
		}			
	}
	
	public class LogEventRequest_ChangeNameLoad : GSTypedRequest<LogEventRequest_ChangeNameLoad, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_ChangeNameLoad() : base("LogEventRequest"){
			request.AddString("eventKey", "ChangeNameLoad");
		}
		
		public LogEventRequest_ChangeNameLoad Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_ChangeNameLoad : GSTypedRequest<LogChallengeEventRequest_ChangeNameLoad, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_ChangeNameLoad() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "ChangeNameLoad");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_ChangeNameLoad SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_ChangeNameLoad Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_ChatToAll : GSTypedRequest<LogEventRequest_ChatToAll, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_ChatToAll() : base("LogEventRequest"){
			request.AddString("eventKey", "ChatToAll");
		}
		
		public LogEventRequest_ChatToAll Set_Players( string value )
		{
			request.AddString("Players", value);
			return this;
		}
		
		public LogEventRequest_ChatToAll Set_Message( string value )
		{
			request.AddString("Message", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_ChatToAll : GSTypedRequest<LogChallengeEventRequest_ChatToAll, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_ChatToAll() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "ChatToAll");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_ChatToAll SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_ChatToAll Set_Players( string value )
		{
			request.AddString("Players", value);
			return this;
		}
		public LogChallengeEventRequest_ChatToAll Set_Message( string value )
		{
			request.AddString("Message", value);
			return this;
		}
	}
	
	public class LogEventRequest_Country : GSTypedRequest<LogEventRequest_Country, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_Country() : base("LogEventRequest"){
			request.AddString("eventKey", "Country");
		}
	}
	
	public class LogChallengeEventRequest_Country : GSTypedRequest<LogChallengeEventRequest_Country, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_Country() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "Country");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_Country SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_Day : GSTypedRequest<LogEventRequest_Day, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_Day() : base("LogEventRequest"){
			request.AddString("eventKey", "Day");
		}
		
		public LogEventRequest_Day Set_Day( string value )
		{
			request.AddString("Day", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_Day : GSTypedRequest<LogChallengeEventRequest_Day, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_Day() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "Day");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_Day SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_Day Set_Day( string value )
		{
			request.AddString("Day", value);
			return this;
		}
	}
	
	public class LogEventRequest_declineFriendRequest : GSTypedRequest<LogEventRequest_declineFriendRequest, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_declineFriendRequest() : base("LogEventRequest"){
			request.AddString("eventKey", "declineFriendRequest");
		}
		
		public LogEventRequest_declineFriendRequest Set_playerId( string value )
		{
			request.AddString("playerId", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_declineFriendRequest : GSTypedRequest<LogChallengeEventRequest_declineFriendRequest, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_declineFriendRequest() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "declineFriendRequest");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_declineFriendRequest SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_declineFriendRequest Set_playerId( string value )
		{
			request.AddString("playerId", value);
			return this;
		}
	}
	
	public class LogEventRequest_DeleteKeysMesage : GSTypedRequest<LogEventRequest_DeleteKeysMesage, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_DeleteKeysMesage() : base("LogEventRequest"){
			request.AddString("eventKey", "DeleteKeysMesage");
		}
		
		public LogEventRequest_DeleteKeysMesage Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_DeleteKeysMesage : GSTypedRequest<LogChallengeEventRequest_DeleteKeysMesage, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_DeleteKeysMesage() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "DeleteKeysMesage");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_DeleteKeysMesage SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_DeleteKeysMesage Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_deletePlayer : GSTypedRequest<LogEventRequest_deletePlayer, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_deletePlayer() : base("LogEventRequest"){
			request.AddString("eventKey", "deletePlayer");
		}
	}
	
	public class LogChallengeEventRequest_deletePlayer : GSTypedRequest<LogChallengeEventRequest_deletePlayer, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_deletePlayer() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "deletePlayer");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_deletePlayer SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_DeleteTour : GSTypedRequest<LogEventRequest_DeleteTour, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_DeleteTour() : base("LogEventRequest"){
			request.AddString("eventKey", "DeleteTour");
		}
		
		public LogEventRequest_DeleteTour Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_DeleteTour : GSTypedRequest<LogChallengeEventRequest_DeleteTour, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_DeleteTour() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "DeleteTour");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_DeleteTour SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_DeleteTour Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_EndGame : GSTypedRequest<LogEventRequest_EndGame, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_EndGame() : base("LogEventRequest"){
			request.AddString("eventKey", "EndGame");
		}
		
		public LogEventRequest_EndGame Set_score( string value )
		{
			request.AddString("score", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_EndGame : GSTypedRequest<LogChallengeEventRequest_EndGame, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_EndGame() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "EndGame");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_EndGame SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_EndGame Set_score( string value )
		{
			request.AddString("score", value);
			return this;
		}
	}
	
	public class LogEventRequest_Event : GSTypedRequest<LogEventRequest_Event, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_Event() : base("LogEventRequest"){
			request.AddString("eventKey", "Event");
		}
	}
	
	public class LogChallengeEventRequest_Event : GSTypedRequest<LogChallengeEventRequest_Event, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_Event() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "Event");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_Event SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_findPlayer : GSTypedRequest<LogEventRequest_findPlayer, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_findPlayer() : base("LogEventRequest"){
			request.AddString("eventKey", "findPlayer");
		}
		
		public LogEventRequest_findPlayer Set_Level( string value )
		{
			request.AddString("Level", value);
			return this;
		}
		
		public LogEventRequest_findPlayer Set_country( string value )
		{
			request.AddString("country", value);
			return this;
		}
		
		public LogEventRequest_findPlayer Set_userName( string value )
		{
			request.AddString("userName", value);
			return this;
		}
		
		public LogEventRequest_findPlayer Set_displayName( string value )
		{
			request.AddString("displayName", value);
			return this;
		}
		
		public LogEventRequest_findPlayer Set_city( string value )
		{
			request.AddString("city", value);
			return this;
		}
		public LogEventRequest_findPlayer Set_score( long value )
		{
			request.AddNumber("score", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_findPlayer : GSTypedRequest<LogChallengeEventRequest_findPlayer, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_findPlayer() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "findPlayer");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_findPlayer SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_findPlayer Set_Level( string value )
		{
			request.AddString("Level", value);
			return this;
		}
		public LogChallengeEventRequest_findPlayer Set_country( string value )
		{
			request.AddString("country", value);
			return this;
		}
		public LogChallengeEventRequest_findPlayer Set_userName( string value )
		{
			request.AddString("userName", value);
			return this;
		}
		public LogChallengeEventRequest_findPlayer Set_displayName( string value )
		{
			request.AddString("displayName", value);
			return this;
		}
		public LogChallengeEventRequest_findPlayer Set_city( string value )
		{
			request.AddString("city", value);
			return this;
		}
		public LogChallengeEventRequest_findPlayer Set_score( long value )
		{
			request.AddNumber("score", value);
			return this;
		}			
	}
	
	public class LogEventRequest_friendList : GSTypedRequest<LogEventRequest_friendList, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_friendList() : base("LogEventRequest"){
			request.AddString("eventKey", "friendList");
		}
	}
	
	public class LogChallengeEventRequest_friendList : GSTypedRequest<LogChallengeEventRequest_friendList, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_friendList() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "friendList");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_friendList SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_friendmapPosition : GSTypedRequest<LogEventRequest_friendmapPosition, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_friendmapPosition() : base("LogEventRequest"){
			request.AddString("eventKey", "friendmapPosition");
		}
		
		public LogEventRequest_friendmapPosition Set_Track( string value )
		{
			request.AddString("Track", value);
			return this;
		}
		public LogEventRequest_friendmapPosition Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_friendmapPosition : GSTypedRequest<LogChallengeEventRequest_friendmapPosition, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_friendmapPosition() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "friendmapPosition");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_friendmapPosition SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_friendmapPosition Set_Track( string value )
		{
			request.AddString("Track", value);
			return this;
		}
		public LogChallengeEventRequest_friendmapPosition Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
	}
	
	public class LogEventRequest_friendRequest : GSTypedRequest<LogEventRequest_friendRequest, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_friendRequest() : base("LogEventRequest"){
			request.AddString("eventKey", "friendRequest");
		}
		
		public LogEventRequest_friendRequest Set_player_id( string value )
		{
			request.AddString("player_id", value);
			return this;
		}
		
		public LogEventRequest_friendRequest Set_group( string value )
		{
			request.AddString("group", value);
			return this;
		}
		
		public LogEventRequest_friendRequest Set_message( string value )
		{
			request.AddString("message", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_friendRequest : GSTypedRequest<LogChallengeEventRequest_friendRequest, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_friendRequest() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "friendRequest");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_friendRequest SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_friendRequest Set_player_id( string value )
		{
			request.AddString("player_id", value);
			return this;
		}
		public LogChallengeEventRequest_friendRequest Set_group( string value )
		{
			request.AddString("group", value);
			return this;
		}
		public LogChallengeEventRequest_friendRequest Set_message( string value )
		{
			request.AddString("message", value);
			return this;
		}
	}
	
	public class LogEventRequest_GetCurrency : GSTypedRequest<LogEventRequest_GetCurrency, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_GetCurrency() : base("LogEventRequest"){
			request.AddString("eventKey", "GetCurrency");
		}
		public LogEventRequest_GetCurrency Set_Value( long value )
		{
			request.AddNumber("Value", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_GetCurrency : GSTypedRequest<LogChallengeEventRequest_GetCurrency, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_GetCurrency() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "GetCurrency");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_GetCurrency SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_GetCurrency Set_Value( long value )
		{
			request.AddNumber("Value", value);
			return this;
		}			
	}
	
	public class LogEventRequest_GET_KEY_DATAS : GSTypedRequest<LogEventRequest_GET_KEY_DATAS, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_GET_KEY_DATAS() : base("LogEventRequest"){
			request.AddString("eventKey", "GET_KEY_DATAS");
		}
		
		public LogEventRequest_GET_KEY_DATAS Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_GET_KEY_DATAS : GSTypedRequest<LogChallengeEventRequest_GET_KEY_DATAS, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_GET_KEY_DATAS() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "GET_KEY_DATAS");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_GET_KEY_DATAS SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_GET_KEY_DATAS Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_get_players : GSTypedRequest<LogEventRequest_get_players, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_get_players() : base("LogEventRequest"){
			request.AddString("eventKey", "get_players");
		}
		
		public LogEventRequest_get_players Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_get_players : GSTypedRequest<LogChallengeEventRequest_get_players, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_get_players() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "get_players");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_get_players SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_get_players Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_get_players2 : GSTypedRequest<LogEventRequest_get_players2, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_get_players2() : base("LogEventRequest"){
			request.AddString("eventKey", "get_players2");
		}
		
		public LogEventRequest_get_players2 Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_get_players2 : GSTypedRequest<LogChallengeEventRequest_get_players2, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_get_players2() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "get_players2");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_get_players2 SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_get_players2 Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_GET_RACE_DATA : GSTypedRequest<LogEventRequest_GET_RACE_DATA, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_GET_RACE_DATA() : base("LogEventRequest"){
			request.AddString("eventKey", "GET_RACE_DATA");
		}
		
		public LogEventRequest_GET_RACE_DATA Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_GET_RACE_DATA : GSTypedRequest<LogChallengeEventRequest_GET_RACE_DATA, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_GET_RACE_DATA() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "GET_RACE_DATA");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_GET_RACE_DATA SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_GET_RACE_DATA Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_GetBoosts : GSTypedRequest<LogEventRequest_GetBoosts, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_GetBoosts() : base("LogEventRequest"){
			request.AddString("eventKey", "GetBoosts");
		}
		public LogEventRequest_GetBoosts Set_Boosts( GSData value )
		{
			request.AddObject("Boosts", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_GetBoosts : GSTypedRequest<LogChallengeEventRequest_GetBoosts, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_GetBoosts() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "GetBoosts");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_GetBoosts SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_GetBoosts Set_Boosts( GSData value )
		{
			request.AddObject("Boosts", value);
			return this;
		}
		
	}
	
	public class LogEventRequest_GetLoadTour : GSTypedRequest<LogEventRequest_GetLoadTour, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_GetLoadTour() : base("LogEventRequest"){
			request.AddString("eventKey", "GetLoadTour");
		}
		
		public LogEventRequest_GetLoadTour Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_GetLoadTour : GSTypedRequest<LogChallengeEventRequest_GetLoadTour, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_GetLoadTour() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "GetLoadTour");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_GetLoadTour SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_GetLoadTour Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_getPlayerFriends : GSTypedRequest<LogEventRequest_getPlayerFriends, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_getPlayerFriends() : base("LogEventRequest"){
			request.AddString("eventKey", "getPlayerFriends");
		}
		
		public LogEventRequest_getPlayerFriends Set_group( string value )
		{
			request.AddString("group", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_getPlayerFriends : GSTypedRequest<LogChallengeEventRequest_getPlayerFriends, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_getPlayerFriends() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "getPlayerFriends");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_getPlayerFriends SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_getPlayerFriends Set_group( string value )
		{
			request.AddString("group", value);
			return this;
		}
	}
	
	public class LogEventRequest_GetReachedLevel : GSTypedRequest<LogEventRequest_GetReachedLevel, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_GetReachedLevel() : base("LogEventRequest"){
			request.AddString("eventKey", "GetReachedLevel");
		}
		public LogEventRequest_GetReachedLevel Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_GetReachedLevel : GSTypedRequest<LogChallengeEventRequest_GetReachedLevel, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_GetReachedLevel() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "GetReachedLevel");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_GetReachedLevel SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_GetReachedLevel Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
	}
	
	public class LogEventRequest_GetStars : GSTypedRequest<LogEventRequest_GetStars, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_GetStars() : base("LogEventRequest"){
			request.AddString("eventKey", "GetStars");
		}
		public LogEventRequest_GetStars Set_Stars( long value )
		{
			request.AddNumber("Stars", value);
			return this;
		}			
		public LogEventRequest_GetStars Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_GetStars : GSTypedRequest<LogChallengeEventRequest_GetStars, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_GetStars() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "GetStars");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_GetStars SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_GetStars Set_Stars( long value )
		{
			request.AddNumber("Stars", value);
			return this;
		}			
		public LogChallengeEventRequest_GetStars Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
	}
	
	public class LogEventRequest_GetStarsAndKey : GSTypedRequest<LogEventRequest_GetStarsAndKey, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_GetStarsAndKey() : base("LogEventRequest"){
			request.AddString("eventKey", "GetStarsAndKey");
		}
		
		public LogEventRequest_GetStarsAndKey Set_getdata( string value )
		{
			request.AddString("getdata", value);
			return this;
		}
		public LogEventRequest_GetStarsAndKey Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
		public LogEventRequest_GetStarsAndKey Set_Stars( long value )
		{
			request.AddNumber("Stars", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_GetStarsAndKey : GSTypedRequest<LogChallengeEventRequest_GetStarsAndKey, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_GetStarsAndKey() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "GetStarsAndKey");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_GetStarsAndKey SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_GetStarsAndKey Set_getdata( string value )
		{
			request.AddString("getdata", value);
			return this;
		}
		public LogChallengeEventRequest_GetStarsAndKey Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
		public LogChallengeEventRequest_GetStarsAndKey Set_Stars( long value )
		{
			request.AddNumber("Stars", value);
			return this;
		}			
	}
	
	public class LogEventRequest_GettBoosts : GSTypedRequest<LogEventRequest_GettBoosts, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_GettBoosts() : base("LogEventRequest"){
			request.AddString("eventKey", "GettBoosts");
		}
		public LogEventRequest_GettBoosts Set_Boosts( long value )
		{
			request.AddNumber("Boosts", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_GettBoosts : GSTypedRequest<LogChallengeEventRequest_GettBoosts, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_GettBoosts() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "GettBoosts");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_GettBoosts SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_GettBoosts Set_Boosts( long value )
		{
			request.AddNumber("Boosts", value);
			return this;
		}			
	}
	
	public class LogEventRequest_groupGet : GSTypedRequest<LogEventRequest_groupGet, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_groupGet() : base("LogEventRequest"){
			request.AddString("eventKey", "groupGet");
		}
		
		public LogEventRequest_groupGet Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_groupGet : GSTypedRequest<LogChallengeEventRequest_groupGet, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_groupGet() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "groupGet");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_groupGet SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_groupGet Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_groupSet : GSTypedRequest<LogEventRequest_groupSet, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_groupSet() : base("LogEventRequest"){
			request.AddString("eventKey", "groupSet");
		}
		public LogEventRequest_groupSet Set_GHOST_DATA( GSData value )
		{
			request.AddObject("GHOST_DATA", value);
			return this;
		}			
		
		public LogEventRequest_groupSet Set_NameTurnir( string value )
		{
			request.AddString("NameTurnir", value);
			return this;
		}
		public LogEventRequest_groupSet Set_EnterTime( long value )
		{
			request.AddNumber("EnterTime", value);
			return this;
		}			
		
		public LogEventRequest_groupSet Set_EnterQuit( string value )
		{
			request.AddString("EnterQuit", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_groupSet : GSTypedRequest<LogChallengeEventRequest_groupSet, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_groupSet() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "groupSet");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_groupSet SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_groupSet Set_GHOST_DATA( GSData value )
		{
			request.AddObject("GHOST_DATA", value);
			return this;
		}
		
		public LogChallengeEventRequest_groupSet Set_NameTurnir( string value )
		{
			request.AddString("NameTurnir", value);
			return this;
		}
		public LogChallengeEventRequest_groupSet Set_EnterTime( long value )
		{
			request.AddNumber("EnterTime", value);
			return this;
		}			
		public LogChallengeEventRequest_groupSet Set_EnterQuit( string value )
		{
			request.AddString("EnterQuit", value);
			return this;
		}
	}
	
	public class LogEventRequest_InputScore : GSTypedRequest<LogEventRequest_InputScore, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_InputScore() : base("LogEventRequest"){
			request.AddString("eventKey", "InputScore");
		}
		public LogEventRequest_InputScore Set_score( long value )
		{
			request.AddNumber("score", value);
			return this;
		}			
		
		public LogEventRequest_InputScore Set_league( string value )
		{
			request.AddString("league", value);
			return this;
		}
		public LogEventRequest_InputScore Set_division( long value )
		{
			request.AddNumber("division", value);
			return this;
		}			
		
		public LogEventRequest_InputScore Set_date( string value )
		{
			request.AddString("date", value);
			return this;
		}
		
		public LogEventRequest_InputScore Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_InputScore : GSTypedRequest<LogChallengeEventRequest_InputScore, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_InputScore() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "InputScore");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_InputScore SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_InputScore Set_score( long value )
		{
			request.AddNumber("score", value);
			return this;
		}			
		public LogChallengeEventRequest_InputScore Set_league( string value )
		{
			request.AddString("league", value);
			return this;
		}
		public LogChallengeEventRequest_InputScore Set_division( long value )
		{
			request.AddNumber("division", value);
			return this;
		}			
		public LogChallengeEventRequest_InputScore Set_date( string value )
		{
			request.AddString("date", value);
			return this;
		}
		public LogChallengeEventRequest_InputScore Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_KeyStoreData : GSTypedRequest<LogEventRequest_KeyStoreData, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_KeyStoreData() : base("LogEventRequest"){
			request.AddString("eventKey", "KeyStoreData");
		}
		public LogEventRequest_KeyStoreData Set_GHOST_DATA( GSData value )
		{
			request.AddObject("GHOST_DATA", value);
			return this;
		}			
		
		public LogEventRequest_KeyStoreData Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
		public LogEventRequest_KeyStoreData Set_TIME( long value )
		{
			request.AddNumber("TIME", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_KeyStoreData : GSTypedRequest<LogChallengeEventRequest_KeyStoreData, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_KeyStoreData() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "KeyStoreData");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_KeyStoreData SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_KeyStoreData Set_GHOST_DATA( GSData value )
		{
			request.AddObject("GHOST_DATA", value);
			return this;
		}
		
		public LogChallengeEventRequest_KeyStoreData Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
		public LogChallengeEventRequest_KeyStoreData Set_TIME( long value )
		{
			request.AddNumber("TIME", value);
			return this;
		}			
	}
	
	public class LogEventRequest_Level : GSTypedRequest<LogEventRequest_Level, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_Level() : base("LogEventRequest"){
			request.AddString("eventKey", "Level");
		}
		public LogEventRequest_Level Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
		public LogEventRequest_Level Set_Score( long value )
		{
			request.AddNumber("Score", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_Level : GSTypedRequest<LogChallengeEventRequest_Level, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_Level() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "Level");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_Level SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_Level Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
		public LogChallengeEventRequest_Level Set_Score( long value )
		{
			request.AddNumber("Score", value);
			return this;
		}			
	}
	
	public class LogEventRequest_Loadbooster : GSTypedRequest<LogEventRequest_Loadbooster, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_Loadbooster() : base("LogEventRequest"){
			request.AddString("eventKey", "Loadbooster");
		}
		
		public LogEventRequest_Loadbooster Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_Loadbooster : GSTypedRequest<LogChallengeEventRequest_Loadbooster, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_Loadbooster() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "Loadbooster");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_Loadbooster SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_Loadbooster Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_LoadboosterAdmin : GSTypedRequest<LogEventRequest_LoadboosterAdmin, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_LoadboosterAdmin() : base("LogEventRequest"){
			request.AddString("eventKey", "LoadboosterAdmin");
		}
		
		public LogEventRequest_LoadboosterAdmin Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_LoadboosterAdmin : GSTypedRequest<LogChallengeEventRequest_LoadboosterAdmin, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_LoadboosterAdmin() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "LoadboosterAdmin");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_LoadboosterAdmin SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_LoadboosterAdmin Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_LoadTurnir : GSTypedRequest<LogEventRequest_LoadTurnir, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_LoadTurnir() : base("LogEventRequest"){
			request.AddString("eventKey", "LoadTurnir");
		}
		
		public LogEventRequest_LoadTurnir Set_NameTurnir( string value )
		{
			request.AddString("NameTurnir", value);
			return this;
		}
		
		public LogEventRequest_LoadTurnir Set_EnterTime( string value )
		{
			request.AddString("EnterTime", value);
			return this;
		}
		
		public LogEventRequest_LoadTurnir Set_Name( string value )
		{
			request.AddString("Name", value);
			return this;
		}
		public LogEventRequest_LoadTurnir Set_Score2( long value )
		{
			request.AddNumber("Score2", value);
			return this;
		}			
		public LogEventRequest_LoadTurnir Set_GHOST_DATA( GSData value )
		{
			request.AddObject("GHOST_DATA", value);
			return this;
		}			
		
		public LogEventRequest_LoadTurnir Set_EnterQuit( string value )
		{
			request.AddString("EnterQuit", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_LoadTurnir : GSTypedRequest<LogChallengeEventRequest_LoadTurnir, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_LoadTurnir() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "LoadTurnir");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_LoadTurnir SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_LoadTurnir Set_NameTurnir( string value )
		{
			request.AddString("NameTurnir", value);
			return this;
		}
		public LogChallengeEventRequest_LoadTurnir Set_EnterTime( string value )
		{
			request.AddString("EnterTime", value);
			return this;
		}
		public LogChallengeEventRequest_LoadTurnir Set_Name( string value )
		{
			request.AddString("Name", value);
			return this;
		}
		public LogChallengeEventRequest_LoadTurnir Set_Score2( long value )
		{
			request.AddNumber("Score2", value);
			return this;
		}			
		public LogChallengeEventRequest_LoadTurnir Set_GHOST_DATA( GSData value )
		{
			request.AddObject("GHOST_DATA", value);
			return this;
		}
		
		public LogChallengeEventRequest_LoadTurnir Set_EnterQuit( string value )
		{
			request.AddString("EnterQuit", value);
			return this;
		}
	}
	
	public class LogEventRequest_lvlcustom : GSTypedRequest<LogEventRequest_lvlcustom, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_lvlcustom() : base("LogEventRequest"){
			request.AddString("eventKey", "lvlcustom");
		}
		public LogEventRequest_lvlcustom Set_level( long value )
		{
			request.AddNumber("level", value);
			return this;
		}			
		
		public LogEventRequest_lvlcustom Set_url( string value )
		{
			request.AddString("url", value);
			return this;
		}
		public LogEventRequest_lvlcustom Set_score( long value )
		{
			request.AddNumber("score", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_lvlcustom : GSTypedRequest<LogChallengeEventRequest_lvlcustom, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_lvlcustom() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "lvlcustom");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_lvlcustom SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_lvlcustom Set_level( long value )
		{
			request.AddNumber("level", value);
			return this;
		}			
		public LogChallengeEventRequest_lvlcustom Set_url( string value )
		{
			request.AddString("url", value);
			return this;
		}
		public LogChallengeEventRequest_lvlcustom Set_score( long value )
		{
			request.AddNumber("score", value);
			return this;
		}			
	}
	
	public class LogEventRequest_PhotoUrlEvent : GSTypedRequest<LogEventRequest_PhotoUrlEvent, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_PhotoUrlEvent() : base("LogEventRequest"){
			request.AddString("eventKey", "PhotoUrlEvent");
		}
		public LogEventRequest_PhotoUrlEvent Set_TourScore( long value )
		{
			request.AddNumber("TourScore", value);
			return this;
		}			
		
		public LogEventRequest_PhotoUrlEvent Set_PhotoUrl( string value )
		{
			request.AddString("PhotoUrl", value);
			return this;
		}
		
		public LogEventRequest_PhotoUrlEvent Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_PhotoUrlEvent : GSTypedRequest<LogChallengeEventRequest_PhotoUrlEvent, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_PhotoUrlEvent() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "PhotoUrlEvent");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_PhotoUrlEvent SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_PhotoUrlEvent Set_TourScore( long value )
		{
			request.AddNumber("TourScore", value);
			return this;
		}			
		public LogChallengeEventRequest_PhotoUrlEvent Set_PhotoUrl( string value )
		{
			request.AddString("PhotoUrl", value);
			return this;
		}
		public LogChallengeEventRequest_PhotoUrlEvent Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_PhotoUrlPackage : GSTypedRequest<LogEventRequest_PhotoUrlPackage, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_PhotoUrlPackage() : base("LogEventRequest"){
			request.AddString("eventKey", "PhotoUrlPackage");
		}
		
		public LogEventRequest_PhotoUrlPackage Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
		public LogEventRequest_PhotoUrlPackage Set_Rank( long value )
		{
			request.AddNumber("Rank", value);
			return this;
		}			
		
		public LogEventRequest_PhotoUrlPackage Set_PhotoUrl( string value )
		{
			request.AddString("PhotoUrl", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_PhotoUrlPackage : GSTypedRequest<LogChallengeEventRequest_PhotoUrlPackage, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_PhotoUrlPackage() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "PhotoUrlPackage");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_PhotoUrlPackage SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_PhotoUrlPackage Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
		public LogChallengeEventRequest_PhotoUrlPackage Set_Rank( long value )
		{
			request.AddNumber("Rank", value);
			return this;
		}			
		public LogChallengeEventRequest_PhotoUrlPackage Set_PhotoUrl( string value )
		{
			request.AddString("PhotoUrl", value);
			return this;
		}
	}
	
	public class LogEventRequest_Placement : GSTypedRequest<LogEventRequest_Placement, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_Placement() : base("LogEventRequest"){
			request.AddString("eventKey", "Placement");
		}
		
		public LogEventRequest_Placement Set_score( string value )
		{
			request.AddString("score", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_Placement : GSTypedRequest<LogChallengeEventRequest_Placement, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_Placement() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "Placement");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_Placement SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_Placement Set_score( string value )
		{
			request.AddString("score", value);
			return this;
		}
	}
	
	public class LogEventRequest_PLANT_SEED : GSTypedRequest<LogEventRequest_PLANT_SEED, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_PLANT_SEED() : base("LogEventRequest"){
			request.AddString("eventKey", "PLANT_SEED");
		}
		public LogEventRequest_PLANT_SEED Set_x( long value )
		{
			request.AddNumber("x", value);
			return this;
		}			
		public LogEventRequest_PLANT_SEED Set_y( long value )
		{
			request.AddNumber("y", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_PLANT_SEED : GSTypedRequest<LogChallengeEventRequest_PLANT_SEED, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_PLANT_SEED() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "PLANT_SEED");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_PLANT_SEED SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_PLANT_SEED Set_x( long value )
		{
			request.AddNumber("x", value);
			return this;
		}			
		public LogChallengeEventRequest_PLANT_SEED Set_y( long value )
		{
			request.AddNumber("y", value);
			return this;
		}			
	}
	
	public class LogEventRequest_player_boosts : GSTypedRequest<LogEventRequest_player_boosts, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_player_boosts() : base("LogEventRequest"){
			request.AddString("eventKey", "player_boosts");
		}
		public LogEventRequest_player_boosts Set_GHOST_DATA( GSData value )
		{
			request.AddObject("GHOST_DATA", value);
			return this;
		}			
		
		public LogEventRequest_player_boosts Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
		public LogEventRequest_player_boosts Set_TIME( long value )
		{
			request.AddNumber("TIME", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_player_boosts : GSTypedRequest<LogChallengeEventRequest_player_boosts, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_player_boosts() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "player_boosts");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_player_boosts SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_player_boosts Set_GHOST_DATA( GSData value )
		{
			request.AddObject("GHOST_DATA", value);
			return this;
		}
		
		public LogChallengeEventRequest_player_boosts Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
		public LogChallengeEventRequest_player_boosts Set_TIME( long value )
		{
			request.AddNumber("TIME", value);
			return this;
		}			
	}
	
	public class LogEventRequest_playerboostAdd : GSTypedRequest<LogEventRequest_playerboostAdd, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_playerboostAdd() : base("LogEventRequest"){
			request.AddString("eventKey", "playerboostAdd");
		}
		public LogEventRequest_playerboostAdd Set_GHOST_DATA( GSData value )
		{
			request.AddObject("GHOST_DATA", value);
			return this;
		}			
		
		public LogEventRequest_playerboostAdd Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
		public LogEventRequest_playerboostAdd Set_TIME( long value )
		{
			request.AddNumber("TIME", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_playerboostAdd : GSTypedRequest<LogChallengeEventRequest_playerboostAdd, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_playerboostAdd() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "playerboostAdd");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_playerboostAdd SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_playerboostAdd Set_GHOST_DATA( GSData value )
		{
			request.AddObject("GHOST_DATA", value);
			return this;
		}
		
		public LogChallengeEventRequest_playerboostAdd Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
		public LogChallengeEventRequest_playerboostAdd Set_TIME( long value )
		{
			request.AddNumber("TIME", value);
			return this;
		}			
	}
	
	public class LogEventRequest_PROG_UPDATE : GSTypedRequest<LogEventRequest_PROG_UPDATE, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_PROG_UPDATE() : base("LogEventRequest"){
			request.AddString("eventKey", "PROG_UPDATE");
		}
		
		public LogEventRequest_PROG_UPDATE Set_PATH( string value )
		{
			request.AddString("PATH", value);
			return this;
		}
		public LogEventRequest_PROG_UPDATE Set_VALUE( GSData value )
		{
			request.AddObject("VALUE", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_PROG_UPDATE : GSTypedRequest<LogChallengeEventRequest_PROG_UPDATE, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_PROG_UPDATE() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "PROG_UPDATE");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_PROG_UPDATE SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_PROG_UPDATE Set_PATH( string value )
		{
			request.AddString("PATH", value);
			return this;
		}
		public LogChallengeEventRequest_PROG_UPDATE Set_VALUE( GSData value )
		{
			request.AddObject("VALUE", value);
			return this;
		}
		
	}
	
	public class LogEventRequest_PROGRESS_QUERY : GSTypedRequest<LogEventRequest_PROGRESS_QUERY, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_PROGRESS_QUERY() : base("LogEventRequest"){
			request.AddString("eventKey", "PROGRESS_QUERY");
		}
		
		public LogEventRequest_PROGRESS_QUERY Set_PATH( string value )
		{
			request.AddString("PATH", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_PROGRESS_QUERY : GSTypedRequest<LogChallengeEventRequest_PROGRESS_QUERY, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_PROGRESS_QUERY() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "PROGRESS_QUERY");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_PROGRESS_QUERY SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_PROGRESS_QUERY Set_PATH( string value )
		{
			request.AddString("PATH", value);
			return this;
		}
	}
	
	public class LogEventRequest_SaveBombStripePackage : GSTypedRequest<LogEventRequest_SaveBombStripePackage, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_SaveBombStripePackage() : base("LogEventRequest"){
			request.AddString("eventKey", "SaveBombStripePackage");
		}
		public LogEventRequest_SaveBombStripePackage Set_Bomb( long value )
		{
			request.AddNumber("Bomb", value);
			return this;
		}			
		public LogEventRequest_SaveBombStripePackage Set_Stripe( long value )
		{
			request.AddNumber("Stripe", value);
			return this;
		}			
		public LogEventRequest_SaveBombStripePackage Set_Package( long value )
		{
			request.AddNumber("Package", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_SaveBombStripePackage : GSTypedRequest<LogChallengeEventRequest_SaveBombStripePackage, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_SaveBombStripePackage() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "SaveBombStripePackage");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_SaveBombStripePackage SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_SaveBombStripePackage Set_Bomb( long value )
		{
			request.AddNumber("Bomb", value);
			return this;
		}			
		public LogChallengeEventRequest_SaveBombStripePackage Set_Stripe( long value )
		{
			request.AddNumber("Stripe", value);
			return this;
		}			
		public LogChallengeEventRequest_SaveBombStripePackage Set_Package( long value )
		{
			request.AddNumber("Package", value);
			return this;
		}			
	}
	
	public class LogEventRequest_saveProfileVK : GSTypedRequest<LogEventRequest_saveProfileVK, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_saveProfileVK() : base("LogEventRequest"){
			request.AddString("eventKey", "saveProfileVK");
		}
		
		public LogEventRequest_saveProfileVK Set_id( string value )
		{
			request.AddString("id", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_saveProfileVK : GSTypedRequest<LogChallengeEventRequest_saveProfileVK, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_saveProfileVK() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "saveProfileVK");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_saveProfileVK SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_saveProfileVK Set_id( string value )
		{
			request.AddString("id", value);
			return this;
		}
	}
	
	public class LogEventRequest_Score : GSTypedRequest<LogEventRequest_Score, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_Score() : base("LogEventRequest"){
			request.AddString("eventKey", "Score");
		}
		public LogEventRequest_Score Set_Score( GSData value )
		{
			request.AddObject("Score", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_Score : GSTypedRequest<LogChallengeEventRequest_Score, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_Score() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "Score");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_Score SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_Score Set_Score( GSData value )
		{
			request.AddObject("Score", value);
			return this;
		}
		
	}
	
	public class LogEventRequest_Score_Evt : GSTypedRequest<LogEventRequest_Score_Evt, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_Score_Evt() : base("LogEventRequest"){
			request.AddString("eventKey", "Score_Evt");
		}
		public LogEventRequest_Score_Evt Set_SCORE_ATTR( long value )
		{
			request.AddNumber("SCORE_ATTR", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_Score_Evt : GSTypedRequest<LogChallengeEventRequest_Score_Evt, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_Score_Evt() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "Score_Evt");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_Score_Evt SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_Score_Evt Set_SCORE_ATTR( long value )
		{
			request.AddNumber("SCORE_ATTR", value);
			return this;
		}			
	}
	
	public class LogEventRequest_Score2 : GSTypedRequest<LogEventRequest_Score2, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_Score2() : base("LogEventRequest"){
			request.AddString("eventKey", "Score2");
		}
		public LogEventRequest_Score2 Set_Score2( long value )
		{
			request.AddNumber("Score2", value);
			return this;
		}			
		
		public LogEventRequest_Score2 Set_NameTour( string value )
		{
			request.AddString("NameTour", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_Score2 : GSTypedRequest<LogChallengeEventRequest_Score2, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_Score2() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "Score2");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_Score2 SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_Score2 Set_Score2( long value )
		{
			request.AddNumber("Score2", value);
			return this;
		}			
		public LogChallengeEventRequest_Score2 Set_NameTour( string value )
		{
			request.AddString("NameTour", value);
			return this;
		}
	}
	
	public class LogEventRequest_ScoreLevel : GSTypedRequest<LogEventRequest_ScoreLevel, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_ScoreLevel() : base("LogEventRequest"){
			request.AddString("eventKey", "ScoreLevel");
		}
		public LogEventRequest_ScoreLevel Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
		public LogEventRequest_ScoreLevel Set_Score( long value )
		{
			request.AddNumber("Score", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_ScoreLevel : GSTypedRequest<LogChallengeEventRequest_ScoreLevel, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_ScoreLevel() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "ScoreLevel");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_ScoreLevel SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_ScoreLevel Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
		public LogChallengeEventRequest_ScoreLevel Set_Score( long value )
		{
			request.AddNumber("Score", value);
			return this;
		}			
	}
	
	public class LogEventRequest_ScriptMessage : GSTypedRequest<LogEventRequest_ScriptMessage, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_ScriptMessage() : base("LogEventRequest"){
			request.AddString("eventKey", "ScriptMessage");
		}
	}
	
	public class LogChallengeEventRequest_ScriptMessage : GSTypedRequest<LogChallengeEventRequest_ScriptMessage, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_ScriptMessage() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "ScriptMessage");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_ScriptMessage SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_SetBombSum : GSTypedRequest<LogEventRequest_SetBombSum, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_SetBombSum() : base("LogEventRequest"){
			request.AddString("eventKey", "SetBombSum");
		}
		public LogEventRequest_SetBombSum Set_BombDonat( long value )
		{
			request.AddNumber("BombDonat", value);
			return this;
		}			
		public LogEventRequest_SetBombSum Set_Bomb( long value )
		{
			request.AddNumber("Bomb", value);
			return this;
		}			
		
		public LogEventRequest_SetBombSum Set_PhotoUrl( string value )
		{
			request.AddString("PhotoUrl", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_SetBombSum : GSTypedRequest<LogChallengeEventRequest_SetBombSum, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_SetBombSum() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "SetBombSum");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_SetBombSum SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_SetBombSum Set_BombDonat( long value )
		{
			request.AddNumber("BombDonat", value);
			return this;
		}			
		public LogChallengeEventRequest_SetBombSum Set_Bomb( long value )
		{
			request.AddNumber("Bomb", value);
			return this;
		}			
		public LogChallengeEventRequest_SetBombSum Set_PhotoUrl( string value )
		{
			request.AddString("PhotoUrl", value);
			return this;
		}
	}
	
	public class LogEventRequest_SetBoosts : GSTypedRequest<LogEventRequest_SetBoosts, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_SetBoosts() : base("LogEventRequest"){
			request.AddString("eventKey", "SetBoosts");
		}
		public LogEventRequest_SetBoosts Set_Boosts( GSData value )
		{
			request.AddObject("Boosts", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_SetBoosts : GSTypedRequest<LogChallengeEventRequest_SetBoosts, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_SetBoosts() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "SetBoosts");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_SetBoosts SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_SetBoosts Set_Boosts( GSData value )
		{
			request.AddObject("Boosts", value);
			return this;
		}
		
	}
	
	public class LogEventRequest_SetCurrency : GSTypedRequest<LogEventRequest_SetCurrency, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_SetCurrency() : base("LogEventRequest"){
			request.AddString("eventKey", "SetCurrency");
		}
		public LogEventRequest_SetCurrency Set_Value( long value )
		{
			request.AddNumber("Value", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_SetCurrency : GSTypedRequest<LogChallengeEventRequest_SetCurrency, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_SetCurrency() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "SetCurrency");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_SetCurrency SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_SetCurrency Set_Value( long value )
		{
			request.AddNumber("Value", value);
			return this;
		}			
	}
	
	public class LogEventRequest_SetKeyAndStars : GSTypedRequest<LogEventRequest_SetKeyAndStars, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_SetKeyAndStars() : base("LogEventRequest"){
			request.AddString("eventKey", "SetKeyAndStars");
		}
		public LogEventRequest_SetKeyAndStars Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
		public LogEventRequest_SetKeyAndStars Set_Stars( long value )
		{
			request.AddNumber("Stars", value);
			return this;
		}			
		public LogEventRequest_SetKeyAndStars Set_Key( long value )
		{
			request.AddNumber("Key", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_SetKeyAndStars : GSTypedRequest<LogChallengeEventRequest_SetKeyAndStars, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_SetKeyAndStars() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "SetKeyAndStars");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_SetKeyAndStars SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_SetKeyAndStars Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
		public LogChallengeEventRequest_SetKeyAndStars Set_Stars( long value )
		{
			request.AddNumber("Stars", value);
			return this;
		}			
		public LogChallengeEventRequest_SetKeyAndStars Set_Key( long value )
		{
			request.AddNumber("Key", value);
			return this;
		}			
	}
	
	public class LogEventRequest_SetLoadTour : GSTypedRequest<LogEventRequest_SetLoadTour, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_SetLoadTour() : base("LogEventRequest"){
			request.AddString("eventKey", "SetLoadTour");
		}
		public LogEventRequest_SetLoadTour Set_GHOST_DATA( GSData value )
		{
			request.AddObject("GHOST_DATA", value);
			return this;
		}			
		
		public LogEventRequest_SetLoadTour Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
		public LogEventRequest_SetLoadTour Set_TIME( long value )
		{
			request.AddNumber("TIME", value);
			return this;
		}			
		
		public LogEventRequest_SetLoadTour Set_EnterQuit( string value )
		{
			request.AddString("EnterQuit", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_SetLoadTour : GSTypedRequest<LogChallengeEventRequest_SetLoadTour, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_SetLoadTour() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "SetLoadTour");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_SetLoadTour SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_SetLoadTour Set_GHOST_DATA( GSData value )
		{
			request.AddObject("GHOST_DATA", value);
			return this;
		}
		
		public LogChallengeEventRequest_SetLoadTour Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
		public LogChallengeEventRequest_SetLoadTour Set_TIME( long value )
		{
			request.AddNumber("TIME", value);
			return this;
		}			
		public LogChallengeEventRequest_SetLoadTour Set_EnterQuit( string value )
		{
			request.AddString("EnterQuit", value);
			return this;
		}
	}
	
	public class LogEventRequest_SetPicture : GSTypedRequest<LogEventRequest_SetPicture, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_SetPicture() : base("LogEventRequest"){
			request.AddString("eventKey", "SetPicture");
		}
		public LogEventRequest_SetPicture Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
		
		public LogEventRequest_SetPicture Set_player_id( string value )
		{
			request.AddString("player_id", value);
			return this;
		}
		
		public LogEventRequest_SetPicture Set_url( string value )
		{
			request.AddString("url", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_SetPicture : GSTypedRequest<LogChallengeEventRequest_SetPicture, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_SetPicture() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "SetPicture");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_SetPicture SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_SetPicture Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
		public LogChallengeEventRequest_SetPicture Set_player_id( string value )
		{
			request.AddString("player_id", value);
			return this;
		}
		public LogChallengeEventRequest_SetPicture Set_url( string value )
		{
			request.AddString("url", value);
			return this;
		}
	}
	
	public class LogEventRequest_SetProfile : GSTypedRequest<LogEventRequest_SetProfile, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_SetProfile() : base("LogEventRequest"){
			request.AddString("eventKey", "SetProfile");
		}
		public LogEventRequest_SetProfile Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
		
		public LogEventRequest_SetProfile Set_url( string value )
		{
			request.AddString("url", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_SetProfile : GSTypedRequest<LogChallengeEventRequest_SetProfile, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_SetProfile() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "SetProfile");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_SetProfile SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_SetProfile Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
		public LogChallengeEventRequest_SetProfile Set_url( string value )
		{
			request.AddString("url", value);
			return this;
		}
	}
	
	public class LogEventRequest_SetReachedLevel : GSTypedRequest<LogEventRequest_SetReachedLevel, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_SetReachedLevel() : base("LogEventRequest"){
			request.AddString("eventKey", "SetReachedLevel");
		}
		public LogEventRequest_SetReachedLevel Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_SetReachedLevel : GSTypedRequest<LogChallengeEventRequest_SetReachedLevel, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_SetReachedLevel() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "SetReachedLevel");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_SetReachedLevel SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_SetReachedLevel Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
	}
	
	public class LogEventRequest_SetStars : GSTypedRequest<LogEventRequest_SetStars, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_SetStars() : base("LogEventRequest"){
			request.AddString("eventKey", "SetStars");
		}
		public LogEventRequest_SetStars Set_Stars( long value )
		{
			request.AddNumber("Stars", value);
			return this;
		}			
		public LogEventRequest_SetStars Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_SetStars : GSTypedRequest<LogChallengeEventRequest_SetStars, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_SetStars() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "SetStars");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_SetStars SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_SetStars Set_Stars( long value )
		{
			request.AddNumber("Stars", value);
			return this;
		}			
		public LogChallengeEventRequest_SetStars Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
	}
	
	public class LogEventRequest_SetStripePackageBombDonat : GSTypedRequest<LogEventRequest_SetStripePackageBombDonat, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_SetStripePackageBombDonat() : base("LogEventRequest"){
			request.AddString("eventKey", "SetStripePackageBombDonat");
		}
		public LogEventRequest_SetStripePackageBombDonat Set_StripeDonat( long value )
		{
			request.AddNumber("StripeDonat", value);
			return this;
		}			
		public LogEventRequest_SetStripePackageBombDonat Set_Stripe( long value )
		{
			request.AddNumber("Stripe", value);
			return this;
		}			
		public LogEventRequest_SetStripePackageBombDonat Set_PackageDonat( long value )
		{
			request.AddNumber("PackageDonat", value);
			return this;
		}			
		public LogEventRequest_SetStripePackageBombDonat Set_Package( long value )
		{
			request.AddNumber("Package", value);
			return this;
		}			
		public LogEventRequest_SetStripePackageBombDonat Set_BombDonat( long value )
		{
			request.AddNumber("BombDonat", value);
			return this;
		}			
		public LogEventRequest_SetStripePackageBombDonat Set_Bomb( long value )
		{
			request.AddNumber("Bomb", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_SetStripePackageBombDonat : GSTypedRequest<LogChallengeEventRequest_SetStripePackageBombDonat, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_SetStripePackageBombDonat() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "SetStripePackageBombDonat");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_SetStripePackageBombDonat SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_SetStripePackageBombDonat Set_StripeDonat( long value )
		{
			request.AddNumber("StripeDonat", value);
			return this;
		}			
		public LogChallengeEventRequest_SetStripePackageBombDonat Set_Stripe( long value )
		{
			request.AddNumber("Stripe", value);
			return this;
		}			
		public LogChallengeEventRequest_SetStripePackageBombDonat Set_PackageDonat( long value )
		{
			request.AddNumber("PackageDonat", value);
			return this;
		}			
		public LogChallengeEventRequest_SetStripePackageBombDonat Set_Package( long value )
		{
			request.AddNumber("Package", value);
			return this;
		}			
		public LogChallengeEventRequest_SetStripePackageBombDonat Set_BombDonat( long value )
		{
			request.AddNumber("BombDonat", value);
			return this;
		}			
		public LogChallengeEventRequest_SetStripePackageBombDonat Set_Bomb( long value )
		{
			request.AddNumber("Bomb", value);
			return this;
		}			
	}
	
	public class LogEventRequest_SetStripeSum : GSTypedRequest<LogEventRequest_SetStripeSum, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_SetStripeSum() : base("LogEventRequest"){
			request.AddString("eventKey", "SetStripeSum");
		}
		public LogEventRequest_SetStripeSum Set_StripeDonat( long value )
		{
			request.AddNumber("StripeDonat", value);
			return this;
		}			
		public LogEventRequest_SetStripeSum Set_Stripe( long value )
		{
			request.AddNumber("Stripe", value);
			return this;
		}			
		
		public LogEventRequest_SetStripeSum Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_SetStripeSum : GSTypedRequest<LogChallengeEventRequest_SetStripeSum, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_SetStripeSum() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "SetStripeSum");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_SetStripeSum SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_SetStripeSum Set_StripeDonat( long value )
		{
			request.AddNumber("StripeDonat", value);
			return this;
		}			
		public LogChallengeEventRequest_SetStripeSum Set_Stripe( long value )
		{
			request.AddNumber("Stripe", value);
			return this;
		}			
		public LogChallengeEventRequest_SetStripeSum Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_SpendCurrency : GSTypedRequest<LogEventRequest_SpendCurrency, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_SpendCurrency() : base("LogEventRequest"){
			request.AddString("eventKey", "SpendCurrency");
		}
		public LogEventRequest_SpendCurrency Set_Value( long value )
		{
			request.AddNumber("Value", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_SpendCurrency : GSTypedRequest<LogChallengeEventRequest_SpendCurrency, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_SpendCurrency() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "SpendCurrency");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_SpendCurrency SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_SpendCurrency Set_Value( long value )
		{
			request.AddNumber("Value", value);
			return this;
		}			
	}
	
	public class LogEventRequest_Stars : GSTypedRequest<LogEventRequest_Stars, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_Stars() : base("LogEventRequest"){
			request.AddString("eventKey", "Stars");
		}
		public LogEventRequest_Stars Set_Stars( long value )
		{
			request.AddNumber("Stars", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_Stars : GSTypedRequest<LogChallengeEventRequest_Stars, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_Stars() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "Stars");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_Stars SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_Stars Set_Stars( long value )
		{
			request.AddNumber("Stars", value);
			return this;
		}			
	}
	
	public class LogEventRequest_STORE_RACE_DATA : GSTypedRequest<LogEventRequest_STORE_RACE_DATA, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_STORE_RACE_DATA() : base("LogEventRequest"){
			request.AddString("eventKey", "STORE_RACE_DATA");
		}
		
		public LogEventRequest_STORE_RACE_DATA Set_GHOST_DATA( string value )
		{
			request.AddString("GHOST_DATA", value);
			return this;
		}
		public LogEventRequest_STORE_RACE_DATA Set_TRACK( GSData value )
		{
			request.AddObject("TRACK", value);
			return this;
		}			
		public LogEventRequest_STORE_RACE_DATA Set_TIME( long value )
		{
			request.AddNumber("TIME", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_STORE_RACE_DATA : GSTypedRequest<LogChallengeEventRequest_STORE_RACE_DATA, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_STORE_RACE_DATA() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "STORE_RACE_DATA");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_STORE_RACE_DATA SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_STORE_RACE_DATA Set_GHOST_DATA( string value )
		{
			request.AddString("GHOST_DATA", value);
			return this;
		}
		public LogChallengeEventRequest_STORE_RACE_DATA Set_TRACK( GSData value )
		{
			request.AddObject("TRACK", value);
			return this;
		}
		
		public LogChallengeEventRequest_STORE_RACE_DATA Set_TIME( long value )
		{
			request.AddNumber("TIME", value);
			return this;
		}			
	}
	
	public class LogEventRequest_StripePackageBombDonat : GSTypedRequest<LogEventRequest_StripePackageBombDonat, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_StripePackageBombDonat() : base("LogEventRequest"){
			request.AddString("eventKey", "StripePackageBombDonat");
		}
		public LogEventRequest_StripePackageBombDonat Set_Stripe( long value )
		{
			request.AddNumber("Stripe", value);
			return this;
		}			
		public LogEventRequest_StripePackageBombDonat Set_Package( long value )
		{
			request.AddNumber("Package", value);
			return this;
		}			
		public LogEventRequest_StripePackageBombDonat Set_Bomb( long value )
		{
			request.AddNumber("Bomb", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_StripePackageBombDonat : GSTypedRequest<LogChallengeEventRequest_StripePackageBombDonat, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_StripePackageBombDonat() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "StripePackageBombDonat");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_StripePackageBombDonat SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_StripePackageBombDonat Set_Stripe( long value )
		{
			request.AddNumber("Stripe", value);
			return this;
		}			
		public LogChallengeEventRequest_StripePackageBombDonat Set_Package( long value )
		{
			request.AddNumber("Package", value);
			return this;
		}			
		public LogChallengeEventRequest_StripePackageBombDonat Set_Bomb( long value )
		{
			request.AddNumber("Bomb", value);
			return this;
		}			
	}
	
	public class LogEventRequest_SUBMIT_SCORE : GSTypedRequest<LogEventRequest_SUBMIT_SCORE, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_SUBMIT_SCORE() : base("LogEventRequest"){
			request.AddString("eventKey", "SUBMIT_SCORE");
		}
	}
	
	public class LogChallengeEventRequest_SUBMIT_SCORE : GSTypedRequest<LogChallengeEventRequest_SUBMIT_SCORE, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_SUBMIT_SCORE() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "SUBMIT_SCORE");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_SUBMIT_SCORE SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_TournamentNews : GSTypedRequest<LogEventRequest_TournamentNews, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_TournamentNews() : base("LogEventRequest"){
			request.AddString("eventKey", "TournamentNews");
		}
		
		public LogEventRequest_TournamentNews Set_NameTurnir( string value )
		{
			request.AddString("NameTurnir", value);
			return this;
		}
		public LogEventRequest_TournamentNews Set_Division( long value )
		{
			request.AddNumber("Division", value);
			return this;
		}			
		
		public LogEventRequest_TournamentNews Set_league( string value )
		{
			request.AddString("league", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_TournamentNews : GSTypedRequest<LogChallengeEventRequest_TournamentNews, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_TournamentNews() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "TournamentNews");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_TournamentNews SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_TournamentNews Set_NameTurnir( string value )
		{
			request.AddString("NameTurnir", value);
			return this;
		}
		public LogChallengeEventRequest_TournamentNews Set_Division( long value )
		{
			request.AddNumber("Division", value);
			return this;
		}			
		public LogChallengeEventRequest_TournamentNews Set_league( string value )
		{
			request.AddString("league", value);
			return this;
		}
	}
	
	public class LogEventRequest_TourTime : GSTypedRequest<LogEventRequest_TourTime, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_TourTime() : base("LogEventRequest"){
			request.AddString("eventKey", "TourTime");
		}
		
		public LogEventRequest_TourTime Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
		public LogEventRequest_TourTime Set_TIME( long value )
		{
			request.AddNumber("TIME", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_TourTime : GSTypedRequest<LogChallengeEventRequest_TourTime, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_TourTime() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "TourTime");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_TourTime SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_TourTime Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
		public LogChallengeEventRequest_TourTime Set_TIME( long value )
		{
			request.AddNumber("TIME", value);
			return this;
		}			
	}
	
	public class LogEventRequest_TrackUrl : GSTypedRequest<LogEventRequest_TrackUrl, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_TrackUrl() : base("LogEventRequest"){
			request.AddString("eventKey", "TrackUrl");
		}
		
		public LogEventRequest_TrackUrl Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_TrackUrl : GSTypedRequest<LogChallengeEventRequest_TrackUrl, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_TrackUrl() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "TrackUrl");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_TrackUrl SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_TrackUrl Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_TrackUrl2 : GSTypedRequest<LogEventRequest_TrackUrl2, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_TrackUrl2() : base("LogEventRequest"){
			request.AddString("eventKey", "TrackUrl2");
		}
		
		public LogEventRequest_TrackUrl2 Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_TrackUrl2 : GSTypedRequest<LogChallengeEventRequest_TrackUrl2, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_TrackUrl2() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "TrackUrl2");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_TrackUrl2 SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_TrackUrl2 Set_TRACK( string value )
		{
			request.AddString("TRACK", value);
			return this;
		}
	}
	
	public class LogEventRequest_TryTimer : GSTypedRequest<LogEventRequest_TryTimer, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_TryTimer() : base("LogEventRequest"){
			request.AddString("eventKey", "TryTimer");
		}
	}
	
	public class LogChallengeEventRequest_TryTimer : GSTypedRequest<LogChallengeEventRequest_TryTimer, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_TryTimer() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "TryTimer");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_TryTimer SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_TryTimer2 : GSTypedRequest<LogEventRequest_TryTimer2, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_TryTimer2() : base("LogEventRequest"){
			request.AddString("eventKey", "TryTimer2");
		}
	}
	
	public class LogChallengeEventRequest_TryTimer2 : GSTypedRequest<LogChallengeEventRequest_TryTimer2, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_TryTimer2() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "TryTimer2");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_TryTimer2 SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
	}
	
	public class LogEventRequest_updatePlayerInfo : GSTypedRequest<LogEventRequest_updatePlayerInfo, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_updatePlayerInfo() : base("LogEventRequest"){
			request.AddString("eventKey", "updatePlayerInfo");
		}
		public LogEventRequest_updatePlayerInfo Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
		
		public LogEventRequest_updatePlayerInfo Set_country( string value )
		{
			request.AddString("country", value);
			return this;
		}
		
		public LogEventRequest_updatePlayerInfo Set_userName( string value )
		{
			request.AddString("userName", value);
			return this;
		}
		
		public LogEventRequest_updatePlayerInfo Set_displayName( string value )
		{
			request.AddString("displayName", value);
			return this;
		}
		
		public LogEventRequest_updatePlayerInfo Set_city( string value )
		{
			request.AddString("city", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_updatePlayerInfo : GSTypedRequest<LogChallengeEventRequest_updatePlayerInfo, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_updatePlayerInfo() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "updatePlayerInfo");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_updatePlayerInfo SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_updatePlayerInfo Set_Level( long value )
		{
			request.AddNumber("Level", value);
			return this;
		}			
		public LogChallengeEventRequest_updatePlayerInfo Set_country( string value )
		{
			request.AddString("country", value);
			return this;
		}
		public LogChallengeEventRequest_updatePlayerInfo Set_userName( string value )
		{
			request.AddString("userName", value);
			return this;
		}
		public LogChallengeEventRequest_updatePlayerInfo Set_displayName( string value )
		{
			request.AddString("displayName", value);
			return this;
		}
		public LogChallengeEventRequest_updatePlayerInfo Set_city( string value )
		{
			request.AddString("city", value);
			return this;
		}
	}
	
	public class LogEventRequest_urlscore : GSTypedRequest<LogEventRequest_urlscore, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_urlscore() : base("LogEventRequest"){
			request.AddString("eventKey", "urlscore");
		}
		
		public LogEventRequest_urlscore Set_userid( string value )
		{
			request.AddString("userid", value);
			return this;
		}
		
		public LogEventRequest_urlscore Set_url( string value )
		{
			request.AddString("url", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_urlscore : GSTypedRequest<LogChallengeEventRequest_urlscore, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_urlscore() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "urlscore");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_urlscore SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_urlscore Set_userid( string value )
		{
			request.AddString("userid", value);
			return this;
		}
		public LogChallengeEventRequest_urlscore Set_url( string value )
		{
			request.AddString("url", value);
			return this;
		}
	}
	
	public class LogEventRequest_UserId : GSTypedRequest<LogEventRequest_UserId, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_UserId() : base("LogEventRequest"){
			request.AddString("eventKey", "UserId");
		}
		public LogEventRequest_UserId Set_UserId( long value )
		{
			request.AddNumber("UserId", value);
			return this;
		}			
	}
	
	public class LogChallengeEventRequest_UserId : GSTypedRequest<LogChallengeEventRequest_UserId, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_UserId() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "UserId");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_UserId SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_UserId Set_UserId( long value )
		{
			request.AddNumber("UserId", value);
			return this;
		}			
	}
	
	public class LogEventRequest_UserName : GSTypedRequest<LogEventRequest_UserName, LogEventResponse>
	{
	
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogEventResponse (response);
		}
		
		public LogEventRequest_UserName() : base("LogEventRequest"){
			request.AddString("eventKey", "UserName");
		}
		
		public LogEventRequest_UserName Set_UserName( string value )
		{
			request.AddString("UserName", value);
			return this;
		}
	}
	
	public class LogChallengeEventRequest_UserName : GSTypedRequest<LogChallengeEventRequest_UserName, LogChallengeEventResponse>
	{
		public LogChallengeEventRequest_UserName() : base("LogChallengeEventRequest"){
			request.AddString("eventKey", "UserName");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LogChallengeEventResponse (response);
		}
		
		/// <summary>
		/// The challenge ID instance to target
		/// </summary>
		public LogChallengeEventRequest_UserName SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		public LogChallengeEventRequest_UserName Set_UserName( string value )
		{
			request.AddString("UserName", value);
			return this;
		}
	}
	
}
	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_BombLeaderTour : GSTypedRequest<LeaderboardDataRequest_BombLeaderTour,LeaderboardDataResponse_BombLeaderTour>
	{
		public LeaderboardDataRequest_BombLeaderTour() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "BombLeaderTour");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_BombLeaderTour (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_BombLeaderTour SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_BombLeaderTour SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_BombLeaderTour SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_BombLeaderTour SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_BombLeaderTour SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_BombLeaderTour SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_BombLeaderTour SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_BombLeaderTour SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_BombLeaderTour SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_BombLeaderTour : GSTypedRequest<AroundMeLeaderboardRequest_BombLeaderTour,AroundMeLeaderboardResponse_BombLeaderTour>
	{
		public AroundMeLeaderboardRequest_BombLeaderTour() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "BombLeaderTour");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_BombLeaderTour (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_BombLeaderTour SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_BombLeaderTour SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_BombLeaderTour SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_BombLeaderTour SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_BombLeaderTour SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_BombLeaderTour SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_BombLeaderTour SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_BombLeaderTour : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_BombLeaderTour(GSData data) : base(data){}
		public long? Bomb{
			get{return response.GetNumber("Bomb");}
		}
	}
	
	public class LeaderboardDataResponse_BombLeaderTour : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_BombLeaderTour(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_BombLeaderTour> Data_BombLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_BombLeaderTour>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_BombLeaderTour(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_BombLeaderTour> First_BombLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_BombLeaderTour>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_BombLeaderTour(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_BombLeaderTour> Last_BombLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_BombLeaderTour>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_BombLeaderTour(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_BombLeaderTour : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_BombLeaderTour(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_BombLeaderTour> Data_BombLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_BombLeaderTour>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_BombLeaderTour(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_BombLeaderTour> First_BombLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_BombLeaderTour>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_BombLeaderTour(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_BombLeaderTour> Last_BombLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_BombLeaderTour>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_BombLeaderTour(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_Bombs1 : GSTypedRequest<LeaderboardDataRequest_Bombs1,LeaderboardDataResponse_Bombs1>
	{
		public LeaderboardDataRequest_Bombs1() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "Bombs1");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_Bombs1 (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_Bombs1 SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_Bombs1 SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Bombs1 SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_Bombs1 SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_Bombs1 SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_Bombs1 SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Bombs1 SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_Bombs1 SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_Bombs1 SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_Bombs1 : GSTypedRequest<AroundMeLeaderboardRequest_Bombs1,AroundMeLeaderboardResponse_Bombs1>
	{
		public AroundMeLeaderboardRequest_Bombs1() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "Bombs1");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_Bombs1 (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_Bombs1 SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Bombs1 SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Bombs1 SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Bombs1 SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Bombs1 SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Bombs1 SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Bombs1 SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_Bombs1 : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_Bombs1(GSData data) : base(data){}
		public long? Bomb{
			get{return response.GetNumber("Bomb");}
		}
		public long? BombDonat{
			get{return response.GetNumber("BombDonat");}
		}
		public string PhotoUrl{
			get{return response.GetString("PhotoUrl");}
		}
	}
	
	public class LeaderboardDataResponse_Bombs1 : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_Bombs1(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Bombs1> Data_Bombs1{
			get{return new GSEnumerable<_LeaderboardEntry_Bombs1>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Bombs1(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Bombs1> First_Bombs1{
			get{return new GSEnumerable<_LeaderboardEntry_Bombs1>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Bombs1(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Bombs1> Last_Bombs1{
			get{return new GSEnumerable<_LeaderboardEntry_Bombs1>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Bombs1(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_Bombs1 : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_Bombs1(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Bombs1> Data_Bombs1{
			get{return new GSEnumerable<_LeaderboardEntry_Bombs1>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Bombs1(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Bombs1> First_Bombs1{
			get{return new GSEnumerable<_LeaderboardEntry_Bombs1>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Bombs1(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Bombs1> Last_Bombs1{
			get{return new GSEnumerable<_LeaderboardEntry_Bombs1>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Bombs1(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_DifficultBooster : GSTypedRequest<LeaderboardDataRequest_DifficultBooster,LeaderboardDataResponse_DifficultBooster>
	{
		public LeaderboardDataRequest_DifficultBooster() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "DifficultBooster");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_DifficultBooster (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_DifficultBooster SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_DifficultBooster SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_DifficultBooster SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_DifficultBooster SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_DifficultBooster SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_DifficultBooster SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_DifficultBooster SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_DifficultBooster SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_DifficultBooster SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_DifficultBooster : GSTypedRequest<AroundMeLeaderboardRequest_DifficultBooster,AroundMeLeaderboardResponse_DifficultBooster>
	{
		public AroundMeLeaderboardRequest_DifficultBooster() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "DifficultBooster");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_DifficultBooster (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_DifficultBooster SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_DifficultBooster SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_DifficultBooster SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_DifficultBooster SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_DifficultBooster SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_DifficultBooster SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_DifficultBooster SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_DifficultBooster : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_DifficultBooster(GSData data) : base(data){}
		public string Idcurrent{
			get{return response.GetString("Idcurrent");}
		}
		public string boostDropdown{
			get{return response.GetString("boostDropdown");}
		}
		public string boostInput{
			get{return response.GetString("boostInput");}
		}
		public string Coins{
			get{return response.GetString("Coins");}
		}
	}
	
	public class LeaderboardDataResponse_DifficultBooster : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_DifficultBooster(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_DifficultBooster> Data_DifficultBooster{
			get{return new GSEnumerable<_LeaderboardEntry_DifficultBooster>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_DifficultBooster(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_DifficultBooster> First_DifficultBooster{
			get{return new GSEnumerable<_LeaderboardEntry_DifficultBooster>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_DifficultBooster(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_DifficultBooster> Last_DifficultBooster{
			get{return new GSEnumerable<_LeaderboardEntry_DifficultBooster>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_DifficultBooster(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_DifficultBooster : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_DifficultBooster(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_DifficultBooster> Data_DifficultBooster{
			get{return new GSEnumerable<_LeaderboardEntry_DifficultBooster>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_DifficultBooster(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_DifficultBooster> First_DifficultBooster{
			get{return new GSEnumerable<_LeaderboardEntry_DifficultBooster>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_DifficultBooster(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_DifficultBooster> Last_DifficultBooster{
			get{return new GSEnumerable<_LeaderboardEntry_DifficultBooster>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_DifficultBooster(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_Fields : GSTypedRequest<LeaderboardDataRequest_Fields,LeaderboardDataResponse_Fields>
	{
		public LeaderboardDataRequest_Fields() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "Fields");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_Fields (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_Fields SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_Fields SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Fields SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_Fields SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_Fields SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_Fields SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Fields SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_Fields SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_Fields SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_Fields : GSTypedRequest<AroundMeLeaderboardRequest_Fields,AroundMeLeaderboardResponse_Fields>
	{
		public AroundMeLeaderboardRequest_Fields() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "Fields");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_Fields (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_Fields SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Fields SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Fields SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Fields SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Fields SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Fields SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Fields SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_Fields : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_Fields(GSData data) : base(data){}
		public long? score{
			get{return response.GetNumber("score");}
		}
		public long? division{
			get{return response.GetNumber("division");}
		}
		public string league{
			get{return response.GetString("league");}
		}
		public string TRACK{
			get{return response.GetString("TRACK");}
		}
		public string date{
			get{return response.GetString("date");}
		}
	}
	
	public class LeaderboardDataResponse_Fields : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_Fields(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Fields> Data_Fields{
			get{return new GSEnumerable<_LeaderboardEntry_Fields>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Fields(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Fields> First_Fields{
			get{return new GSEnumerable<_LeaderboardEntry_Fields>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Fields(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Fields> Last_Fields{
			get{return new GSEnumerable<_LeaderboardEntry_Fields>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Fields(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_Fields : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_Fields(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Fields> Data_Fields{
			get{return new GSEnumerable<_LeaderboardEntry_Fields>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Fields(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Fields> First_Fields{
			get{return new GSEnumerable<_LeaderboardEntry_Fields>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Fields(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Fields> Last_Fields{
			get{return new GSEnumerable<_LeaderboardEntry_Fields>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Fields(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_findPlayerVk : GSTypedRequest<LeaderboardDataRequest_findPlayerVk,LeaderboardDataResponse_findPlayerVk>
	{
		public LeaderboardDataRequest_findPlayerVk() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "findPlayerVk");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_findPlayerVk (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_findPlayerVk SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_findPlayerVk SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_findPlayerVk SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_findPlayerVk SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_findPlayerVk SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_findPlayerVk SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_findPlayerVk SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_findPlayerVk SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_findPlayerVk SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_findPlayerVk : GSTypedRequest<AroundMeLeaderboardRequest_findPlayerVk,AroundMeLeaderboardResponse_findPlayerVk>
	{
		public AroundMeLeaderboardRequest_findPlayerVk() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "findPlayerVk");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_findPlayerVk (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_findPlayerVk SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_findPlayerVk SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_findPlayerVk SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_findPlayerVk SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_findPlayerVk SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_findPlayerVk SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_findPlayerVk SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_findPlayerVk : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_findPlayerVk(GSData data) : base(data){}
		public string id{
			get{return response.GetString("id");}
		}
	}
	
	public class LeaderboardDataResponse_findPlayerVk : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_findPlayerVk(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_findPlayerVk> Data_findPlayerVk{
			get{return new GSEnumerable<_LeaderboardEntry_findPlayerVk>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_findPlayerVk(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_findPlayerVk> First_findPlayerVk{
			get{return new GSEnumerable<_LeaderboardEntry_findPlayerVk>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_findPlayerVk(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_findPlayerVk> Last_findPlayerVk{
			get{return new GSEnumerable<_LeaderboardEntry_findPlayerVk>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_findPlayerVk(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_findPlayerVk : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_findPlayerVk(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_findPlayerVk> Data_findPlayerVk{
			get{return new GSEnumerable<_LeaderboardEntry_findPlayerVk>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_findPlayerVk(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_findPlayerVk> First_findPlayerVk{
			get{return new GSEnumerable<_LeaderboardEntry_findPlayerVk>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_findPlayerVk(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_findPlayerVk> Last_findPlayerVk{
			get{return new GSEnumerable<_LeaderboardEntry_findPlayerVk>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_findPlayerVk(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_friends_leaderboard : GSTypedRequest<LeaderboardDataRequest_friends_leaderboard,LeaderboardDataResponse_friends_leaderboard>
	{
		public LeaderboardDataRequest_friends_leaderboard() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "friends_leaderboard");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_friends_leaderboard (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_friends_leaderboard SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_friends_leaderboard SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_friends_leaderboard SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_friends_leaderboard SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_friends_leaderboard SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_friends_leaderboard SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_friends_leaderboard SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_friends_leaderboard SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_friends_leaderboard SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_friends_leaderboard : GSTypedRequest<AroundMeLeaderboardRequest_friends_leaderboard,AroundMeLeaderboardResponse_friends_leaderboard>
	{
		public AroundMeLeaderboardRequest_friends_leaderboard() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "friends_leaderboard");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_friends_leaderboard (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_friends_leaderboard SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_friends_leaderboard SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_friends_leaderboard SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_friends_leaderboard SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_friends_leaderboard SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_friends_leaderboard SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_friends_leaderboard SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_friends_leaderboard : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_friends_leaderboard(GSData data) : base(data){}
		public long? Level{
			get{return response.GetNumber("Level");}
		}
	}
	
	public class LeaderboardDataResponse_friends_leaderboard : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_friends_leaderboard(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_friends_leaderboard> Data_friends_leaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_friends_leaderboard>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_friends_leaderboard(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_friends_leaderboard> First_friends_leaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_friends_leaderboard>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_friends_leaderboard(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_friends_leaderboard> Last_friends_leaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_friends_leaderboard>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_friends_leaderboard(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_friends_leaderboard : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_friends_leaderboard(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_friends_leaderboard> Data_friends_leaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_friends_leaderboard>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_friends_leaderboard(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_friends_leaderboard> First_friends_leaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_friends_leaderboard>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_friends_leaderboard(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_friends_leaderboard> Last_friends_leaderboard{
			get{return new GSEnumerable<_LeaderboardEntry_friends_leaderboard>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_friends_leaderboard(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_getphotosPlayer : GSTypedRequest<LeaderboardDataRequest_getphotosPlayer,LeaderboardDataResponse_getphotosPlayer>
	{
		public LeaderboardDataRequest_getphotosPlayer() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "getphotosPlayer");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_getphotosPlayer (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_getphotosPlayer SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_getphotosPlayer SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_getphotosPlayer SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_getphotosPlayer SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_getphotosPlayer SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_getphotosPlayer SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_getphotosPlayer SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_getphotosPlayer SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_getphotosPlayer SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_getphotosPlayer : GSTypedRequest<AroundMeLeaderboardRequest_getphotosPlayer,AroundMeLeaderboardResponse_getphotosPlayer>
	{
		public AroundMeLeaderboardRequest_getphotosPlayer() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "getphotosPlayer");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_getphotosPlayer (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_getphotosPlayer SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_getphotosPlayer SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_getphotosPlayer SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_getphotosPlayer SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_getphotosPlayer SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_getphotosPlayer SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_getphotosPlayer SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_getphotosPlayer : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_getphotosPlayer(GSData data) : base(data){}
		public long? TourScore{
			get{return response.GetNumber("TourScore");}
		}
		public string PhotoUrl{
			get{return response.GetString("PhotoUrl");}
		}
	}
	
	public class LeaderboardDataResponse_getphotosPlayer : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_getphotosPlayer(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_getphotosPlayer> Data_getphotosPlayer{
			get{return new GSEnumerable<_LeaderboardEntry_getphotosPlayer>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_getphotosPlayer(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_getphotosPlayer> First_getphotosPlayer{
			get{return new GSEnumerable<_LeaderboardEntry_getphotosPlayer>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_getphotosPlayer(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_getphotosPlayer> Last_getphotosPlayer{
			get{return new GSEnumerable<_LeaderboardEntry_getphotosPlayer>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_getphotosPlayer(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_getphotosPlayer : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_getphotosPlayer(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_getphotosPlayer> Data_getphotosPlayer{
			get{return new GSEnumerable<_LeaderboardEntry_getphotosPlayer>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_getphotosPlayer(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_getphotosPlayer> First_getphotosPlayer{
			get{return new GSEnumerable<_LeaderboardEntry_getphotosPlayer>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_getphotosPlayer(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_getphotosPlayer> Last_getphotosPlayer{
			get{return new GSEnumerable<_LeaderboardEntry_getphotosPlayer>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_getphotosPlayer(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_LB : GSTypedRequest<LeaderboardDataRequest_LB,LeaderboardDataResponse_LB>
	{
		public LeaderboardDataRequest_LB() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "LB");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_LB (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_LB SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_LB SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_LB SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_LB SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_LB SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_LB SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_LB SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_LB SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_LB SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_LB : GSTypedRequest<AroundMeLeaderboardRequest_LB,AroundMeLeaderboardResponse_LB>
	{
		public AroundMeLeaderboardRequest_LB() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "LB");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_LB (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_LB SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_LB SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_LB SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_LB SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_LB SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_LB SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_LB SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_LB : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_LB(GSData data) : base(data){}
		public string displayName{
			get{return response.GetString("displayName");}
		}
		public string Level{
			get{return response.GetString("Level");}
		}
		public long? score{
			get{return response.GetNumber("score");}
		}
	}
	
	public class LeaderboardDataResponse_LB : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_LB(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_LB> Data_LB{
			get{return new GSEnumerable<_LeaderboardEntry_LB>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_LB(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LB> First_LB{
			get{return new GSEnumerable<_LeaderboardEntry_LB>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_LB(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LB> Last_LB{
			get{return new GSEnumerable<_LeaderboardEntry_LB>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_LB(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_LB : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_LB(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_LB> Data_LB{
			get{return new GSEnumerable<_LeaderboardEntry_LB>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_LB(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LB> First_LB{
			get{return new GSEnumerable<_LeaderboardEntry_LB>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_LB(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LB> Last_LB{
			get{return new GSEnumerable<_LeaderboardEntry_LB>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_LB(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_leader_stars : GSTypedRequest<LeaderboardDataRequest_leader_stars,LeaderboardDataResponse_leader_stars>
	{
		public LeaderboardDataRequest_leader_stars() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "leader_stars");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_leader_stars (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_leader_stars SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_leader_stars SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_leader_stars SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_leader_stars SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_leader_stars SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_leader_stars SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_leader_stars SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_leader_stars SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_leader_stars SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_leader_stars : GSTypedRequest<AroundMeLeaderboardRequest_leader_stars,AroundMeLeaderboardResponse_leader_stars>
	{
		public AroundMeLeaderboardRequest_leader_stars() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "leader_stars");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_leader_stars (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_leader_stars SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_leader_stars SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_leader_stars SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_leader_stars SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_leader_stars SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_leader_stars SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_leader_stars SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_leader_stars : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_leader_stars(GSData data) : base(data){}
		public long? Level{
			get{return response.GetNumber("Level");}
		}
		public long? Stars{
			get{return response.GetNumber("Stars");}
		}
	}
	
	public class LeaderboardDataResponse_leader_stars : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_leader_stars(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_leader_stars> Data_leader_stars{
			get{return new GSEnumerable<_LeaderboardEntry_leader_stars>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_leader_stars(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_leader_stars> First_leader_stars{
			get{return new GSEnumerable<_LeaderboardEntry_leader_stars>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_leader_stars(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_leader_stars> Last_leader_stars{
			get{return new GSEnumerable<_LeaderboardEntry_leader_stars>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_leader_stars(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_leader_stars : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_leader_stars(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_leader_stars> Data_leader_stars{
			get{return new GSEnumerable<_LeaderboardEntry_leader_stars>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_leader_stars(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_leader_stars> First_leader_stars{
			get{return new GSEnumerable<_LeaderboardEntry_leader_stars>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_leader_stars(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_leader_stars> Last_leader_stars{
			get{return new GSEnumerable<_LeaderboardEntry_leader_stars>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_leader_stars(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_LeaderboadTurnir : GSTypedRequest<LeaderboardDataRequest_LeaderboadTurnir,LeaderboardDataResponse_LeaderboadTurnir>
	{
		public LeaderboardDataRequest_LeaderboadTurnir() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "LeaderboadTurnir");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_LeaderboadTurnir (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_LeaderboadTurnir SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_LeaderboadTurnir SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_LeaderboadTurnir SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_LeaderboadTurnir SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_LeaderboadTurnir SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_LeaderboadTurnir SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_LeaderboadTurnir SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_LeaderboadTurnir SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_LeaderboadTurnir SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_LeaderboadTurnir : GSTypedRequest<AroundMeLeaderboardRequest_LeaderboadTurnir,AroundMeLeaderboardResponse_LeaderboadTurnir>
	{
		public AroundMeLeaderboardRequest_LeaderboadTurnir() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "LeaderboadTurnir");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_LeaderboadTurnir (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_LeaderboadTurnir SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_LeaderboadTurnir SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_LeaderboadTurnir SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_LeaderboadTurnir SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_LeaderboadTurnir SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_LeaderboadTurnir SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_LeaderboadTurnir SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_LeaderboadTurnir : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_LeaderboadTurnir(GSData data) : base(data){}
		public string NameTurnir{
			get{return response.GetString("NameTurnir");}
		}
		public long? Score2{
			get{return response.GetNumber("Score2");}
		}
	}
	
	public class LeaderboardDataResponse_LeaderboadTurnir : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_LeaderboadTurnir(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_LeaderboadTurnir> Data_LeaderboadTurnir{
			get{return new GSEnumerable<_LeaderboardEntry_LeaderboadTurnir>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_LeaderboadTurnir(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LeaderboadTurnir> First_LeaderboadTurnir{
			get{return new GSEnumerable<_LeaderboardEntry_LeaderboadTurnir>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_LeaderboadTurnir(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LeaderboadTurnir> Last_LeaderboadTurnir{
			get{return new GSEnumerable<_LeaderboardEntry_LeaderboadTurnir>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_LeaderboadTurnir(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_LeaderboadTurnir : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_LeaderboadTurnir(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_LeaderboadTurnir> Data_LeaderboadTurnir{
			get{return new GSEnumerable<_LeaderboardEntry_LeaderboadTurnir>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_LeaderboadTurnir(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LeaderboadTurnir> First_LeaderboadTurnir{
			get{return new GSEnumerable<_LeaderboardEntry_LeaderboadTurnir>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_LeaderboadTurnir(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LeaderboadTurnir> Last_LeaderboadTurnir{
			get{return new GSEnumerable<_LeaderboardEntry_LeaderboadTurnir>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_LeaderboadTurnir(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_leadkey : GSTypedRequest<LeaderboardDataRequest_leadkey,LeaderboardDataResponse_leadkey>
	{
		public LeaderboardDataRequest_leadkey() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "leadkey");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_leadkey (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_leadkey SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_leadkey SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_leadkey SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_leadkey SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_leadkey SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_leadkey SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_leadkey SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_leadkey SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_leadkey SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_leadkey : GSTypedRequest<AroundMeLeaderboardRequest_leadkey,AroundMeLeaderboardResponse_leadkey>
	{
		public AroundMeLeaderboardRequest_leadkey() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "leadkey");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_leadkey (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_leadkey SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_leadkey SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_leadkey SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_leadkey SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_leadkey SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_leadkey SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_leadkey SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_leadkey : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_leadkey(GSData data) : base(data){}
		public long? Key{
			get{return response.GetNumber("Key");}
		}
	}
	
	public class LeaderboardDataResponse_leadkey : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_leadkey(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_leadkey> Data_leadkey{
			get{return new GSEnumerable<_LeaderboardEntry_leadkey>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_leadkey(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_leadkey> First_leadkey{
			get{return new GSEnumerable<_LeaderboardEntry_leadkey>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_leadkey(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_leadkey> Last_leadkey{
			get{return new GSEnumerable<_LeaderboardEntry_leadkey>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_leadkey(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_leadkey : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_leadkey(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_leadkey> Data_leadkey{
			get{return new GSEnumerable<_LeaderboardEntry_leadkey>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_leadkey(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_leadkey> First_leadkey{
			get{return new GSEnumerable<_LeaderboardEntry_leadkey>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_leadkey(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_leadkey> Last_leadkey{
			get{return new GSEnumerable<_LeaderboardEntry_leadkey>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_leadkey(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_Level : GSTypedRequest<LeaderboardDataRequest_Level,LeaderboardDataResponse_Level>
	{
		public LeaderboardDataRequest_Level() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "Level");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_Level (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_Level SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_Level SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Level SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_Level SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_Level SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_Level SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Level SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_Level SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_Level SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_Level : GSTypedRequest<AroundMeLeaderboardRequest_Level,AroundMeLeaderboardResponse_Level>
	{
		public AroundMeLeaderboardRequest_Level() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "Level");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_Level (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_Level SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Level SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Level SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Level SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Level SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Level SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Level SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_Level : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_Level(GSData data) : base(data){}
		public long? Level{
			get{return response.GetNumber("Level");}
		}
		public long? Score{
			get{return response.GetNumber("Score");}
		}
	}
	
	public class LeaderboardDataResponse_Level : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_Level(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Level> Data_Level{
			get{return new GSEnumerable<_LeaderboardEntry_Level>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Level(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Level> First_Level{
			get{return new GSEnumerable<_LeaderboardEntry_Level>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Level(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Level> Last_Level{
			get{return new GSEnumerable<_LeaderboardEntry_Level>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Level(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_Level : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_Level(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Level> Data_Level{
			get{return new GSEnumerable<_LeaderboardEntry_Level>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Level(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Level> First_Level{
			get{return new GSEnumerable<_LeaderboardEntry_Level>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Level(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Level> Last_Level{
			get{return new GSEnumerable<_LeaderboardEntry_Level>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Level(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_LoadCurrencies : GSTypedRequest<LeaderboardDataRequest_LoadCurrencies,LeaderboardDataResponse_LoadCurrencies>
	{
		public LeaderboardDataRequest_LoadCurrencies() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "LoadCurrencies");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_LoadCurrencies (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_LoadCurrencies SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_LoadCurrencies SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_LoadCurrencies SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_LoadCurrencies SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_LoadCurrencies SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_LoadCurrencies SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_LoadCurrencies SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_LoadCurrencies SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_LoadCurrencies SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_LoadCurrencies : GSTypedRequest<AroundMeLeaderboardRequest_LoadCurrencies,AroundMeLeaderboardResponse_LoadCurrencies>
	{
		public AroundMeLeaderboardRequest_LoadCurrencies() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "LoadCurrencies");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_LoadCurrencies (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_LoadCurrencies SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_LoadCurrencies SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_LoadCurrencies SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_LoadCurrencies SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_LoadCurrencies SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_LoadCurrencies SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_LoadCurrencies SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_LoadCurrencies : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_LoadCurrencies(GSData data) : base(data){}
		public long? MAX_SCORE_ATTR{
			get{return response.GetNumber("MAX-SCORE_ATTR");}
		}
	}
	
	public class LeaderboardDataResponse_LoadCurrencies : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_LoadCurrencies(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_LoadCurrencies> Data_LoadCurrencies{
			get{return new GSEnumerable<_LeaderboardEntry_LoadCurrencies>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_LoadCurrencies(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LoadCurrencies> First_LoadCurrencies{
			get{return new GSEnumerable<_LeaderboardEntry_LoadCurrencies>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_LoadCurrencies(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LoadCurrencies> Last_LoadCurrencies{
			get{return new GSEnumerable<_LeaderboardEntry_LoadCurrencies>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_LoadCurrencies(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_LoadCurrencies : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_LoadCurrencies(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_LoadCurrencies> Data_LoadCurrencies{
			get{return new GSEnumerable<_LeaderboardEntry_LoadCurrencies>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_LoadCurrencies(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LoadCurrencies> First_LoadCurrencies{
			get{return new GSEnumerable<_LeaderboardEntry_LoadCurrencies>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_LoadCurrencies(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_LoadCurrencies> Last_LoadCurrencies{
			get{return new GSEnumerable<_LeaderboardEntry_LoadCurrencies>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_LoadCurrencies(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_News1 : GSTypedRequest<LeaderboardDataRequest_News1,LeaderboardDataResponse_News1>
	{
		public LeaderboardDataRequest_News1() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "News1");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_News1 (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_News1 SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_News1 SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_News1 SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_News1 SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_News1 SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_News1 SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_News1 SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_News1 SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_News1 SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_News1 : GSTypedRequest<AroundMeLeaderboardRequest_News1,AroundMeLeaderboardResponse_News1>
	{
		public AroundMeLeaderboardRequest_News1() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "News1");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_News1 (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_News1 SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_News1 SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_News1 SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_News1 SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_News1 SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_News1 SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_News1 SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_News1 : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_News1(GSData data) : base(data){}
		public string NameTurnir{
			get{return response.GetString("NameTurnir");}
		}
		public long? Division{
			get{return response.GetNumber("Division");}
		}
		public string league{
			get{return response.GetString("league");}
		}
	}
	
	public class LeaderboardDataResponse_News1 : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_News1(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_News1> Data_News1{
			get{return new GSEnumerable<_LeaderboardEntry_News1>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_News1(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_News1> First_News1{
			get{return new GSEnumerable<_LeaderboardEntry_News1>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_News1(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_News1> Last_News1{
			get{return new GSEnumerable<_LeaderboardEntry_News1>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_News1(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_News1 : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_News1(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_News1> Data_News1{
			get{return new GSEnumerable<_LeaderboardEntry_News1>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_News1(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_News1> First_News1{
			get{return new GSEnumerable<_LeaderboardEntry_News1>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_News1(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_News1> Last_News1{
			get{return new GSEnumerable<_LeaderboardEntry_News1>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_News1(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_PackageLeaderTour : GSTypedRequest<LeaderboardDataRequest_PackageLeaderTour,LeaderboardDataResponse_PackageLeaderTour>
	{
		public LeaderboardDataRequest_PackageLeaderTour() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "PackageLeaderTour");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_PackageLeaderTour (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_PackageLeaderTour SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_PackageLeaderTour SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_PackageLeaderTour SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_PackageLeaderTour SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_PackageLeaderTour SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_PackageLeaderTour SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_PackageLeaderTour SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_PackageLeaderTour SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_PackageLeaderTour SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_PackageLeaderTour : GSTypedRequest<AroundMeLeaderboardRequest_PackageLeaderTour,AroundMeLeaderboardResponse_PackageLeaderTour>
	{
		public AroundMeLeaderboardRequest_PackageLeaderTour() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "PackageLeaderTour");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_PackageLeaderTour (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_PackageLeaderTour SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_PackageLeaderTour SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_PackageLeaderTour SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_PackageLeaderTour SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_PackageLeaderTour SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_PackageLeaderTour SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_PackageLeaderTour SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_PackageLeaderTour : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_PackageLeaderTour(GSData data) : base(data){}
		public long? Package{
			get{return response.GetNumber("Package");}
		}
	}
	
	public class LeaderboardDataResponse_PackageLeaderTour : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_PackageLeaderTour(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_PackageLeaderTour> Data_PackageLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_PackageLeaderTour>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_PackageLeaderTour(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_PackageLeaderTour> First_PackageLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_PackageLeaderTour>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_PackageLeaderTour(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_PackageLeaderTour> Last_PackageLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_PackageLeaderTour>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_PackageLeaderTour(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_PackageLeaderTour : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_PackageLeaderTour(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_PackageLeaderTour> Data_PackageLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_PackageLeaderTour>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_PackageLeaderTour(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_PackageLeaderTour> First_PackageLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_PackageLeaderTour>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_PackageLeaderTour(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_PackageLeaderTour> Last_PackageLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_PackageLeaderTour>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_PackageLeaderTour(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_Rank : GSTypedRequest<LeaderboardDataRequest_Rank,LeaderboardDataResponse_Rank>
	{
		public LeaderboardDataRequest_Rank() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "Rank");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_Rank (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_Rank SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_Rank SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Rank SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_Rank SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_Rank SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_Rank SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Rank SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_Rank SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_Rank SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_Rank : GSTypedRequest<AroundMeLeaderboardRequest_Rank,AroundMeLeaderboardResponse_Rank>
	{
		public AroundMeLeaderboardRequest_Rank() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "Rank");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_Rank (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_Rank SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Rank SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Rank SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Rank SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Rank SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Rank SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Rank SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_Rank : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_Rank(GSData data) : base(data){}
	}
	
	public class LeaderboardDataResponse_Rank : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_Rank(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Rank> Data_Rank{
			get{return new GSEnumerable<_LeaderboardEntry_Rank>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Rank(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Rank> First_Rank{
			get{return new GSEnumerable<_LeaderboardEntry_Rank>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Rank(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Rank> Last_Rank{
			get{return new GSEnumerable<_LeaderboardEntry_Rank>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Rank(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_Rank : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_Rank(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Rank> Data_Rank{
			get{return new GSEnumerable<_LeaderboardEntry_Rank>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Rank(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Rank> First_Rank{
			get{return new GSEnumerable<_LeaderboardEntry_Rank>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Rank(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Rank> Last_Rank{
			get{return new GSEnumerable<_LeaderboardEntry_Rank>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Rank(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_ReachetLevel : GSTypedRequest<LeaderboardDataRequest_ReachetLevel,LeaderboardDataResponse_ReachetLevel>
	{
		public LeaderboardDataRequest_ReachetLevel() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "ReachetLevel");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_ReachetLevel (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_ReachetLevel SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_ReachetLevel SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_ReachetLevel SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_ReachetLevel SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_ReachetLevel SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_ReachetLevel SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_ReachetLevel SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_ReachetLevel SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_ReachetLevel SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_ReachetLevel : GSTypedRequest<AroundMeLeaderboardRequest_ReachetLevel,AroundMeLeaderboardResponse_ReachetLevel>
	{
		public AroundMeLeaderboardRequest_ReachetLevel() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "ReachetLevel");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_ReachetLevel (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_ReachetLevel SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_ReachetLevel SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_ReachetLevel SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_ReachetLevel SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_ReachetLevel SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_ReachetLevel SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_ReachetLevel SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_ReachetLevel : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_ReachetLevel(GSData data) : base(data){}
		public long? Level{
			get{return response.GetNumber("Level");}
		}
	}
	
	public class LeaderboardDataResponse_ReachetLevel : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_ReachetLevel(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_ReachetLevel> Data_ReachetLevel{
			get{return new GSEnumerable<_LeaderboardEntry_ReachetLevel>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_ReachetLevel(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_ReachetLevel> First_ReachetLevel{
			get{return new GSEnumerable<_LeaderboardEntry_ReachetLevel>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_ReachetLevel(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_ReachetLevel> Last_ReachetLevel{
			get{return new GSEnumerable<_LeaderboardEntry_ReachetLevel>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_ReachetLevel(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_ReachetLevel : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_ReachetLevel(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_ReachetLevel> Data_ReachetLevel{
			get{return new GSEnumerable<_LeaderboardEntry_ReachetLevel>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_ReachetLevel(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_ReachetLevel> First_ReachetLevel{
			get{return new GSEnumerable<_LeaderboardEntry_ReachetLevel>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_ReachetLevel(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_ReachetLevel> Last_ReachetLevel{
			get{return new GSEnumerable<_LeaderboardEntry_ReachetLevel>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_ReachetLevel(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_Score : GSTypedRequest<LeaderboardDataRequest_Score,LeaderboardDataResponse_Score>
	{
		public LeaderboardDataRequest_Score() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "Score");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_Score (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_Score SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_Score SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Score SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_Score SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_Score SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_Score SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Score SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_Score SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_Score SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_Score : GSTypedRequest<AroundMeLeaderboardRequest_Score,AroundMeLeaderboardResponse_Score>
	{
		public AroundMeLeaderboardRequest_Score() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "Score");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_Score (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_Score SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Score SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Score SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Score SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Score SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Score SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Score SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_Score : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_Score(GSData data) : base(data){}
		public long? Score{
			get{return response.GetNumber("Score");}
		}
	}
	
	public class LeaderboardDataResponse_Score : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_Score(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Score> Data_Score{
			get{return new GSEnumerable<_LeaderboardEntry_Score>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Score(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Score> First_Score{
			get{return new GSEnumerable<_LeaderboardEntry_Score>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Score(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Score> Last_Score{
			get{return new GSEnumerable<_LeaderboardEntry_Score>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Score(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_Score : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_Score(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Score> Data_Score{
			get{return new GSEnumerable<_LeaderboardEntry_Score>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Score(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Score> First_Score{
			get{return new GSEnumerable<_LeaderboardEntry_Score>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Score(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Score> Last_Score{
			get{return new GSEnumerable<_LeaderboardEntry_Score>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Score(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_SetAvatar : GSTypedRequest<LeaderboardDataRequest_SetAvatar,LeaderboardDataResponse_SetAvatar>
	{
		public LeaderboardDataRequest_SetAvatar() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "SetAvatar");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_SetAvatar (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_SetAvatar SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_SetAvatar SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_SetAvatar SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_SetAvatar SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_SetAvatar SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_SetAvatar SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_SetAvatar SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_SetAvatar SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_SetAvatar SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_SetAvatar : GSTypedRequest<AroundMeLeaderboardRequest_SetAvatar,AroundMeLeaderboardResponse_SetAvatar>
	{
		public AroundMeLeaderboardRequest_SetAvatar() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "SetAvatar");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_SetAvatar (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_SetAvatar SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_SetAvatar SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_SetAvatar SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_SetAvatar SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_SetAvatar SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_SetAvatar SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_SetAvatar SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_SetAvatar : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_SetAvatar(GSData data) : base(data){}
		public long? Level{
			get{return response.GetNumber("Level");}
		}
		public string url{
			get{return response.GetString("url");}
		}
	}
	
	public class LeaderboardDataResponse_SetAvatar : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_SetAvatar(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_SetAvatar> Data_SetAvatar{
			get{return new GSEnumerable<_LeaderboardEntry_SetAvatar>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_SetAvatar(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_SetAvatar> First_SetAvatar{
			get{return new GSEnumerable<_LeaderboardEntry_SetAvatar>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_SetAvatar(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_SetAvatar> Last_SetAvatar{
			get{return new GSEnumerable<_LeaderboardEntry_SetAvatar>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_SetAvatar(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_SetAvatar : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_SetAvatar(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_SetAvatar> Data_SetAvatar{
			get{return new GSEnumerable<_LeaderboardEntry_SetAvatar>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_SetAvatar(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_SetAvatar> First_SetAvatar{
			get{return new GSEnumerable<_LeaderboardEntry_SetAvatar>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_SetAvatar(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_SetAvatar> Last_SetAvatar{
			get{return new GSEnumerable<_LeaderboardEntry_SetAvatar>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_SetAvatar(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_Stripe1 : GSTypedRequest<LeaderboardDataRequest_Stripe1,LeaderboardDataResponse_Stripe1>
	{
		public LeaderboardDataRequest_Stripe1() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "Stripe1");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_Stripe1 (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_Stripe1 SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_Stripe1 SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Stripe1 SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_Stripe1 SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_Stripe1 SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_Stripe1 SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Stripe1 SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_Stripe1 SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_Stripe1 SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_Stripe1 : GSTypedRequest<AroundMeLeaderboardRequest_Stripe1,AroundMeLeaderboardResponse_Stripe1>
	{
		public AroundMeLeaderboardRequest_Stripe1() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "Stripe1");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_Stripe1 (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_Stripe1 SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Stripe1 SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Stripe1 SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Stripe1 SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Stripe1 SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Stripe1 SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Stripe1 SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_Stripe1 : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_Stripe1(GSData data) : base(data){}
		public long? Stripe{
			get{return response.GetNumber("Stripe");}
		}
		public long? StripeDonat{
			get{return response.GetNumber("StripeDonat");}
		}
		public string TRACK{
			get{return response.GetString("TRACK");}
		}
	}
	
	public class LeaderboardDataResponse_Stripe1 : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_Stripe1(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Stripe1> Data_Stripe1{
			get{return new GSEnumerable<_LeaderboardEntry_Stripe1>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Stripe1(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Stripe1> First_Stripe1{
			get{return new GSEnumerable<_LeaderboardEntry_Stripe1>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Stripe1(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Stripe1> Last_Stripe1{
			get{return new GSEnumerable<_LeaderboardEntry_Stripe1>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Stripe1(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_Stripe1 : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_Stripe1(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Stripe1> Data_Stripe1{
			get{return new GSEnumerable<_LeaderboardEntry_Stripe1>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Stripe1(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Stripe1> First_Stripe1{
			get{return new GSEnumerable<_LeaderboardEntry_Stripe1>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Stripe1(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Stripe1> Last_Stripe1{
			get{return new GSEnumerable<_LeaderboardEntry_Stripe1>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Stripe1(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_StripeDonat : GSTypedRequest<LeaderboardDataRequest_StripeDonat,LeaderboardDataResponse_StripeDonat>
	{
		public LeaderboardDataRequest_StripeDonat() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "StripeDonat");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_StripeDonat (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_StripeDonat SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_StripeDonat SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_StripeDonat SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_StripeDonat SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_StripeDonat SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_StripeDonat SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_StripeDonat SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_StripeDonat SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_StripeDonat SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_StripeDonat : GSTypedRequest<AroundMeLeaderboardRequest_StripeDonat,AroundMeLeaderboardResponse_StripeDonat>
	{
		public AroundMeLeaderboardRequest_StripeDonat() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "StripeDonat");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_StripeDonat (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_StripeDonat SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_StripeDonat SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_StripeDonat SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_StripeDonat SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_StripeDonat SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_StripeDonat SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_StripeDonat SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_StripeDonat : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_StripeDonat(GSData data) : base(data){}
		public long? Bomb{
			get{return response.GetNumber("Bomb");}
		}
	}
	
	public class LeaderboardDataResponse_StripeDonat : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_StripeDonat(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_StripeDonat> Data_StripeDonat{
			get{return new GSEnumerable<_LeaderboardEntry_StripeDonat>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_StripeDonat(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_StripeDonat> First_StripeDonat{
			get{return new GSEnumerable<_LeaderboardEntry_StripeDonat>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_StripeDonat(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_StripeDonat> Last_StripeDonat{
			get{return new GSEnumerable<_LeaderboardEntry_StripeDonat>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_StripeDonat(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_StripeDonat : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_StripeDonat(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_StripeDonat> Data_StripeDonat{
			get{return new GSEnumerable<_LeaderboardEntry_StripeDonat>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_StripeDonat(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_StripeDonat> First_StripeDonat{
			get{return new GSEnumerable<_LeaderboardEntry_StripeDonat>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_StripeDonat(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_StripeDonat> Last_StripeDonat{
			get{return new GSEnumerable<_LeaderboardEntry_StripeDonat>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_StripeDonat(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_StripeLeaderTour : GSTypedRequest<LeaderboardDataRequest_StripeLeaderTour,LeaderboardDataResponse_StripeLeaderTour>
	{
		public LeaderboardDataRequest_StripeLeaderTour() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "StripeLeaderTour");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_StripeLeaderTour (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_StripeLeaderTour SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_StripeLeaderTour SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_StripeLeaderTour SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_StripeLeaderTour SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_StripeLeaderTour SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_StripeLeaderTour SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_StripeLeaderTour SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_StripeLeaderTour SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_StripeLeaderTour SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_StripeLeaderTour : GSTypedRequest<AroundMeLeaderboardRequest_StripeLeaderTour,AroundMeLeaderboardResponse_StripeLeaderTour>
	{
		public AroundMeLeaderboardRequest_StripeLeaderTour() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "StripeLeaderTour");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_StripeLeaderTour (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_StripeLeaderTour SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_StripeLeaderTour SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_StripeLeaderTour SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_StripeLeaderTour SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_StripeLeaderTour SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_StripeLeaderTour SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_StripeLeaderTour SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_StripeLeaderTour : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_StripeLeaderTour(GSData data) : base(data){}
		public long? Stripe{
			get{return response.GetNumber("Stripe");}
		}
	}
	
	public class LeaderboardDataResponse_StripeLeaderTour : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_StripeLeaderTour(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_StripeLeaderTour> Data_StripeLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_StripeLeaderTour>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_StripeLeaderTour(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_StripeLeaderTour> First_StripeLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_StripeLeaderTour>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_StripeLeaderTour(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_StripeLeaderTour> Last_StripeLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_StripeLeaderTour>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_StripeLeaderTour(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_StripeLeaderTour : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_StripeLeaderTour(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_StripeLeaderTour> Data_StripeLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_StripeLeaderTour>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_StripeLeaderTour(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_StripeLeaderTour> First_StripeLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_StripeLeaderTour>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_StripeLeaderTour(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_StripeLeaderTour> Last_StripeLeaderTour{
			get{return new GSEnumerable<_LeaderboardEntry_StripeLeaderTour>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_StripeLeaderTour(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_Tour1 : GSTypedRequest<LeaderboardDataRequest_Tour1,LeaderboardDataResponse_Tour1>
	{
		public LeaderboardDataRequest_Tour1() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "Tour1");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_Tour1 (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_Tour1 SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_Tour1 SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Tour1 SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_Tour1 SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_Tour1 SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_Tour1 SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Tour1 SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_Tour1 SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_Tour1 SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_Tour1 : GSTypedRequest<AroundMeLeaderboardRequest_Tour1,AroundMeLeaderboardResponse_Tour1>
	{
		public AroundMeLeaderboardRequest_Tour1() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "Tour1");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_Tour1 (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_Tour1 SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Tour1 SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Tour1 SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Tour1 SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Tour1 SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Tour1 SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Tour1 SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_Tour1 : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_Tour1(GSData data) : base(data){}
		public long? Stripe{
			get{return response.GetNumber("Stripe");}
		}
		public long? StripeDonat{
			get{return response.GetNumber("StripeDonat");}
		}
	}
	
	public class LeaderboardDataResponse_Tour1 : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_Tour1(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Tour1> Data_Tour1{
			get{return new GSEnumerable<_LeaderboardEntry_Tour1>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Tour1(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tour1> First_Tour1{
			get{return new GSEnumerable<_LeaderboardEntry_Tour1>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Tour1(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tour1> Last_Tour1{
			get{return new GSEnumerable<_LeaderboardEntry_Tour1>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Tour1(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_Tour1 : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_Tour1(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Tour1> Data_Tour1{
			get{return new GSEnumerable<_LeaderboardEntry_Tour1>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Tour1(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tour1> First_Tour1{
			get{return new GSEnumerable<_LeaderboardEntry_Tour1>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Tour1(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tour1> Last_Tour1{
			get{return new GSEnumerable<_LeaderboardEntry_Tour1>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Tour1(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_Tour2 : GSTypedRequest<LeaderboardDataRequest_Tour2,LeaderboardDataResponse_Tour2>
	{
		public LeaderboardDataRequest_Tour2() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "Tour2");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_Tour2 (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_Tour2 SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_Tour2 SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Tour2 SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_Tour2 SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_Tour2 SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_Tour2 SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Tour2 SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_Tour2 SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_Tour2 SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_Tour2 : GSTypedRequest<AroundMeLeaderboardRequest_Tour2,AroundMeLeaderboardResponse_Tour2>
	{
		public AroundMeLeaderboardRequest_Tour2() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "Tour2");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_Tour2 (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_Tour2 SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Tour2 SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Tour2 SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Tour2 SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Tour2 SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Tour2 SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Tour2 SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_Tour2 : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_Tour2(GSData data) : base(data){}
		public long? Package{
			get{return response.GetNumber("Package");}
		}
		public long? PackageDonat{
			get{return response.GetNumber("PackageDonat");}
		}
	}
	
	public class LeaderboardDataResponse_Tour2 : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_Tour2(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Tour2> Data_Tour2{
			get{return new GSEnumerable<_LeaderboardEntry_Tour2>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Tour2(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tour2> First_Tour2{
			get{return new GSEnumerable<_LeaderboardEntry_Tour2>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Tour2(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tour2> Last_Tour2{
			get{return new GSEnumerable<_LeaderboardEntry_Tour2>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Tour2(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_Tour2 : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_Tour2(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Tour2> Data_Tour2{
			get{return new GSEnumerable<_LeaderboardEntry_Tour2>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Tour2(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tour2> First_Tour2{
			get{return new GSEnumerable<_LeaderboardEntry_Tour2>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Tour2(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tour2> Last_Tour2{
			get{return new GSEnumerable<_LeaderboardEntry_Tour2>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Tour2(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_Tour3 : GSTypedRequest<LeaderboardDataRequest_Tour3,LeaderboardDataResponse_Tour3>
	{
		public LeaderboardDataRequest_Tour3() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "Tour3");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_Tour3 (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_Tour3 SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_Tour3 SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Tour3 SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_Tour3 SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_Tour3 SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_Tour3 SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Tour3 SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_Tour3 SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_Tour3 SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_Tour3 : GSTypedRequest<AroundMeLeaderboardRequest_Tour3,AroundMeLeaderboardResponse_Tour3>
	{
		public AroundMeLeaderboardRequest_Tour3() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "Tour3");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_Tour3 (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_Tour3 SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Tour3 SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Tour3 SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Tour3 SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Tour3 SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Tour3 SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Tour3 SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_Tour3 : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_Tour3(GSData data) : base(data){}
		public long? Bomb{
			get{return response.GetNumber("Bomb");}
		}
		public long? BombDonat{
			get{return response.GetNumber("BombDonat");}
		}
	}
	
	public class LeaderboardDataResponse_Tour3 : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_Tour3(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Tour3> Data_Tour3{
			get{return new GSEnumerable<_LeaderboardEntry_Tour3>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Tour3(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tour3> First_Tour3{
			get{return new GSEnumerable<_LeaderboardEntry_Tour3>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Tour3(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tour3> Last_Tour3{
			get{return new GSEnumerable<_LeaderboardEntry_Tour3>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Tour3(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_Tour3 : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_Tour3(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Tour3> Data_Tour3{
			get{return new GSEnumerable<_LeaderboardEntry_Tour3>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Tour3(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tour3> First_Tour3{
			get{return new GSEnumerable<_LeaderboardEntry_Tour3>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Tour3(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tour3> Last_Tour3{
			get{return new GSEnumerable<_LeaderboardEntry_Tour3>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Tour3(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_Tour4 : GSTypedRequest<LeaderboardDataRequest_Tour4,LeaderboardDataResponse_Tour4>
	{
		public LeaderboardDataRequest_Tour4() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "Tour4");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_Tour4 (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_Tour4 SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_Tour4 SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Tour4 SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_Tour4 SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_Tour4 SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_Tour4 SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Tour4 SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_Tour4 SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_Tour4 SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_Tour4 : GSTypedRequest<AroundMeLeaderboardRequest_Tour4,AroundMeLeaderboardResponse_Tour4>
	{
		public AroundMeLeaderboardRequest_Tour4() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "Tour4");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_Tour4 (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_Tour4 SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Tour4 SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Tour4 SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Tour4 SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Tour4 SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Tour4 SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Tour4 SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_Tour4 : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_Tour4(GSData data) : base(data){}
	}
	
	public class LeaderboardDataResponse_Tour4 : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_Tour4(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Tour4> Data_Tour4{
			get{return new GSEnumerable<_LeaderboardEntry_Tour4>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Tour4(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tour4> First_Tour4{
			get{return new GSEnumerable<_LeaderboardEntry_Tour4>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Tour4(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tour4> Last_Tour4{
			get{return new GSEnumerable<_LeaderboardEntry_Tour4>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Tour4(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_Tour4 : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_Tour4(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Tour4> Data_Tour4{
			get{return new GSEnumerable<_LeaderboardEntry_Tour4>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Tour4(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tour4> First_Tour4{
			get{return new GSEnumerable<_LeaderboardEntry_Tour4>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Tour4(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tour4> Last_Tour4{
			get{return new GSEnumerable<_LeaderboardEntry_Tour4>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Tour4(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_Tournaments : GSTypedRequest<LeaderboardDataRequest_Tournaments,LeaderboardDataResponse_Tournaments>
	{
		public LeaderboardDataRequest_Tournaments() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "Tournaments");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_Tournaments (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_Tournaments SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_Tournaments SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Tournaments SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_Tournaments SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_Tournaments SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_Tournaments SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_Tournaments SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_Tournaments SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_Tournaments SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_Tournaments : GSTypedRequest<AroundMeLeaderboardRequest_Tournaments,AroundMeLeaderboardResponse_Tournaments>
	{
		public AroundMeLeaderboardRequest_Tournaments() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "Tournaments");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_Tournaments (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_Tournaments SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Tournaments SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Tournaments SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_Tournaments SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_Tournaments SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Tournaments SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_Tournaments SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_Tournaments : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_Tournaments(GSData data) : base(data){}
		public string NameTour{
			get{return response.GetString("NameTour");}
		}
		public long? Score2{
			get{return response.GetNumber("Score2");}
		}
	}
	
	public class LeaderboardDataResponse_Tournaments : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_Tournaments(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Tournaments> Data_Tournaments{
			get{return new GSEnumerable<_LeaderboardEntry_Tournaments>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Tournaments(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tournaments> First_Tournaments{
			get{return new GSEnumerable<_LeaderboardEntry_Tournaments>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Tournaments(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tournaments> Last_Tournaments{
			get{return new GSEnumerable<_LeaderboardEntry_Tournaments>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Tournaments(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_Tournaments : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_Tournaments(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_Tournaments> Data_Tournaments{
			get{return new GSEnumerable<_LeaderboardEntry_Tournaments>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_Tournaments(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tournaments> First_Tournaments{
			get{return new GSEnumerable<_LeaderboardEntry_Tournaments>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_Tournaments(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_Tournaments> Last_Tournaments{
			get{return new GSEnumerable<_LeaderboardEntry_Tournaments>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_Tournaments(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_urlplayers : GSTypedRequest<LeaderboardDataRequest_urlplayers,LeaderboardDataResponse_urlplayers>
	{
		public LeaderboardDataRequest_urlplayers() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "urlplayers");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_urlplayers (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_urlplayers SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_urlplayers SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_urlplayers SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_urlplayers SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_urlplayers SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_urlplayers SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_urlplayers SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_urlplayers SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_urlplayers SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_urlplayers : GSTypedRequest<AroundMeLeaderboardRequest_urlplayers,AroundMeLeaderboardResponse_urlplayers>
	{
		public AroundMeLeaderboardRequest_urlplayers() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "urlplayers");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_urlplayers (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_urlplayers SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_urlplayers SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_urlplayers SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_urlplayers SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_urlplayers SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_urlplayers SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_urlplayers SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_urlplayers : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_urlplayers(GSData data) : base(data){}
		public string url{
			get{return response.GetString("url");}
		}
	}
	
	public class LeaderboardDataResponse_urlplayers : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_urlplayers(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_urlplayers> Data_urlplayers{
			get{return new GSEnumerable<_LeaderboardEntry_urlplayers>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_urlplayers(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_urlplayers> First_urlplayers{
			get{return new GSEnumerable<_LeaderboardEntry_urlplayers>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_urlplayers(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_urlplayers> Last_urlplayers{
			get{return new GSEnumerable<_LeaderboardEntry_urlplayers>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_urlplayers(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_urlplayers : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_urlplayers(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_urlplayers> Data_urlplayers{
			get{return new GSEnumerable<_LeaderboardEntry_urlplayers>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_urlplayers(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_urlplayers> First_urlplayers{
			get{return new GSEnumerable<_LeaderboardEntry_urlplayers>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_urlplayers(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_urlplayers> Last_urlplayers{
			get{return new GSEnumerable<_LeaderboardEntry_urlplayers>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_urlplayers(data);});}
		}
	}
}	
	
	
namespace GameSparks.Api.Requests{
	
	public class LeaderboardDataRequest_urlsLast : GSTypedRequest<LeaderboardDataRequest_urlsLast,LeaderboardDataResponse_urlsLast>
	{
		public LeaderboardDataRequest_urlsLast() : base("LeaderboardDataRequest"){
			request.AddString("leaderboardShortCode", "urlsLast");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new LeaderboardDataResponse_urlsLast (response);
		}		
		
		/// <summary>
		/// The challenge instance to get the leaderboard data for
		/// </summary>
		public LeaderboardDataRequest_urlsLast SetChallengeInstanceId( String challengeInstanceId )
		{
			request.AddString("challengeInstanceId", challengeInstanceId);
			return this;
		}
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public LeaderboardDataRequest_urlsLast SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_urlsLast SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public LeaderboardDataRequest_urlsLast SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public LeaderboardDataRequest_urlsLast SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// The offset into the set of leaderboards returned
		/// </summary>
		public LeaderboardDataRequest_urlsLast SetOffset( long offset )
		{
			request.AddNumber("offset", offset);
			return this;
		}
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public LeaderboardDataRequest_urlsLast SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public LeaderboardDataRequest_urlsLast SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public LeaderboardDataRequest_urlsLast SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
		
	}

	public class AroundMeLeaderboardRequest_urlsLast : GSTypedRequest<AroundMeLeaderboardRequest_urlsLast,AroundMeLeaderboardResponse_urlsLast>
	{
		public AroundMeLeaderboardRequest_urlsLast() : base("AroundMeLeaderboardRequest"){
			request.AddString("leaderboardShortCode", "urlsLast");
		}
		
		protected override GSTypedResponse BuildResponse (GSObject response){
			return new AroundMeLeaderboardResponse_urlsLast (response);
		}		
		
		/// <summary>
		/// The number of items to return in a page (default=50)
		/// </summary>
		public AroundMeLeaderboardRequest_urlsLast SetEntryCount( long entryCount )
		{
			request.AddNumber("entryCount", entryCount);
			return this;
		}
		/// <summary>
		/// A friend id or an array of friend ids to use instead of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_urlsLast SetFriendIds( List<string> friendIds )
		{
			request.AddStringList("friendIds", friendIds);
			return this;
		}
		/// <summary>
		/// Number of entries to include from head of the list
		/// </summary>
		public AroundMeLeaderboardRequest_urlsLast SetIncludeFirst( long includeFirst )
		{
			request.AddNumber("includeFirst", includeFirst);
			return this;
		}
		/// <summary>
		/// Number of entries to include from tail of the list
		/// </summary>
		public AroundMeLeaderboardRequest_urlsLast SetIncludeLast( long includeLast )
		{
			request.AddNumber("includeLast", includeLast);
			return this;
		}
		
		/// <summary>
		/// If True returns a leaderboard of the player's social friends
		/// </summary>
		public AroundMeLeaderboardRequest_urlsLast SetSocial( bool social )
		{
			request.AddBoolean("social", social);
			return this;
		}
		/// <summary>
		/// The IDs of the teams you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_urlsLast SetTeamIds( List<string> teamIds )
		{
			request.AddStringList("teamIds", teamIds);
			return this;
		}
		/// <summary>
		/// The type of team you are interested in
		/// </summary>
		public AroundMeLeaderboardRequest_urlsLast SetTeamTypes( List<string> teamTypes )
		{
			request.AddStringList("teamTypes", teamTypes);
			return this;
		}
	}
}

namespace GameSparks.Api.Responses{
	
	public class _LeaderboardEntry_urlsLast : LeaderboardDataResponse._LeaderboardData{
		public _LeaderboardEntry_urlsLast(GSData data) : base(data){}
		public string userid{
			get{return response.GetString("userid");}
		}
		public string url{
			get{return response.GetString("url");}
		}
	}
	
	public class LeaderboardDataResponse_urlsLast : LeaderboardDataResponse
	{
		public LeaderboardDataResponse_urlsLast(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_urlsLast> Data_urlsLast{
			get{return new GSEnumerable<_LeaderboardEntry_urlsLast>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_urlsLast(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_urlsLast> First_urlsLast{
			get{return new GSEnumerable<_LeaderboardEntry_urlsLast>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_urlsLast(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_urlsLast> Last_urlsLast{
			get{return new GSEnumerable<_LeaderboardEntry_urlsLast>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_urlsLast(data);});}
		}
	}
	
	public class AroundMeLeaderboardResponse_urlsLast : AroundMeLeaderboardResponse
	{
		public AroundMeLeaderboardResponse_urlsLast(GSData data) : base(data){}
		
		public GSEnumerable<_LeaderboardEntry_urlsLast> Data_urlsLast{
			get{return new GSEnumerable<_LeaderboardEntry_urlsLast>(response.GetObjectList("data"), (data) => { return new _LeaderboardEntry_urlsLast(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_urlsLast> First_urlsLast{
			get{return new GSEnumerable<_LeaderboardEntry_urlsLast>(response.GetObjectList("first"), (data) => { return new _LeaderboardEntry_urlsLast(data);});}
		}
		
		public GSEnumerable<_LeaderboardEntry_urlsLast> Last_urlsLast{
			get{return new GSEnumerable<_LeaderboardEntry_urlsLast>(response.GetObjectList("last"), (data) => { return new _LeaderboardEntry_urlsLast(data);});}
		}
	}
}	

namespace GameSparks.Api.Messages {

		public class ScriptMessage_friendOnLineMessage : ScriptMessage {
		
			public new static Action<ScriptMessage_friendOnLineMessage> Listener;
	
			public ScriptMessage_friendOnLineMessage(GSData data) : base(data){}
	
			private static ScriptMessage_friendOnLineMessage Create(GSData data)
			{
				ScriptMessage_friendOnLineMessage message = new ScriptMessage_friendOnLineMessage (data);
				return message;
			}
	
			static ScriptMessage_friendOnLineMessage()
			{
				handlers.Add (".ScriptMessage_friendOnLineMessage", Create);
	
			}
			
			override public void NotifyListeners()
			{
				if (Listener != null)
				{
					Listener (this);
				}
			}
		}
		public class ScriptMessage_friendRequestMessage : ScriptMessage {
		
			public new static Action<ScriptMessage_friendRequestMessage> Listener;
	
			public ScriptMessage_friendRequestMessage(GSData data) : base(data){}
	
			private static ScriptMessage_friendRequestMessage Create(GSData data)
			{
				ScriptMessage_friendRequestMessage message = new ScriptMessage_friendRequestMessage (data);
				return message;
			}
	
			static ScriptMessage_friendRequestMessage()
			{
				handlers.Add (".ScriptMessage_friendRequestMessage", Create);
	
			}
			
			override public void NotifyListeners()
			{
				if (Listener != null)
				{
					Listener (this);
				}
			}
		}

}
