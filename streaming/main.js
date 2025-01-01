const WebTorrent = (await import('webtorrent')).default;
// const fs = require('fs');

const client = new WebTorrent();

const torrentId = 'magnet:?xt=urn:btih:d031ff44407d794f70e49ebf6e8e0e15a28ecc60&dn=The.Neighborhood.S06E03.Welcome.to.the.Other.Butlers.1080p.AMZN.WEB-DL.DDP5.1.H.264-NTb%5BEZTVx.to%5D.mkv%5Beztv%5D&tr=udp%3A%2F%2Ftracker.opentrackr.org%3A1337%2Fannounce&tr=udp%3A%2F%2Fp4p.arenabg.com%3A1337%2Fannounce&tr=udp%3A%2F%2Ftracker.torrent.eu.org%3A451%2Fannounce&tr=udp%3A%2F%2Fopen.stealth.si%3A80%2Fannounce';

client.add(torrentId);

// Listen for the 'torrent' event
client.on('torrent', (torrent) => {
    // Get the torrent's files
    const files = torrent.files;

    // Get the first file (which is the video file)
    const file = files[0];

    // Create a read stream for the file
    const stream = file.createReadStream();

    // Pipe the stream to a video player
    stream.pipe(videoPlayer);
});
