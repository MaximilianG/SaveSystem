using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer (GameManage _gameManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.saveddata";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(_gameManager);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadPlayer ()
    {
        string path = Application.persistentDataPath + "/player.saveddata";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

    public static void EraseSave(int un, int deux, int trois, int quatre, int cinq)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.saveddata";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(un, deux, trois, quatre, cinq);

        formatter.Serialize(stream, data);
        stream.Close();
    }
}
