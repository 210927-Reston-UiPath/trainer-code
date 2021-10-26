function addBorder()
{
    document.getElementById('cat').setAttribute('border', '2px');
    document.querySelector('#cat + p').setAttribute('style', 'border:solid');
}