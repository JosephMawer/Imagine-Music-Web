# Imagine-Music-Web
Personal website for hosting my music @ www.sydimagine.com


The site should be accessible to anyone (no login required) and should immediately load a "player" component, along with tracks, and allow
the user to immediately start live streaming the music. 

Concepts

Audio Player:

- This component will be html and should be able to play media
- file formats should be mp3/mp4


Live Streaming:

Storing Audio Files:
- Use azure blob storage to store my audio files:
- Use database to store track content; think of least expensive way to use a database, maybe a file? sqlite?


As Sahil said, you don't really store the files in the database, but rather, you store links to the files in the database. Every system 
I know of that stores large numbers of big files stores them externally to the database. You store all of the queryable data for the file 
(title, artist, length, etc.) in the database, along with a partial path to the file. When it's time to retrieve the file, you extract 
the file's path, prepend some file root (or URL) to it, and return that. Finally, you probably want datatype varchar for the field names 
that point to the actual files.


Resources
https://localjoost.github.io/downloading-audio-files-from-azure-blob/
https://www.learningcontainer.com/sample-audio-file/
https://developer.mozilla.org/en-US/docs/Web/API/Web_Audio_API#guides_and_tutorials
https://developer.mozilla.org/en-US/docs/Web/Guide/Audio_and_video_delivery/Live_streaming_web_audio_and_video#streaming_audio_and_video_on_demand
