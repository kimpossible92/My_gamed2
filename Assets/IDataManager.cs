using System.Collections.Generic;
using System;

public interface IDataManager
{
    void LoadPicture();
    void SetPlayerScore(int level, int score);
    void LoginWithFriends(Dictionary<string, string> dic, string UserIDFriend, int levelpl);
    void LoadLeaderBoardData();
    void Addpicture(string dic, string UserIDFriend);
    void GetCallPhotoTour4(Action<List<LeadboardPlayerData>> Callback);
    void GetCallPhotoTour5();
    void SetTournament(Dictionary<string, string> dic, string UserIDFriend, string entryTime);
    void SaveControl();
}
