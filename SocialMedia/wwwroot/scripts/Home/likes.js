let likeButton = document.querySelectorAll('.button-like').forEach(x => x.addEventListener('click', function (e) {

    let divElement = e.currentTarget.parentNode.parentNode;
    let imgId = divElement.getElementsByClassName('img-id')[0].value
    //var profilIdLiked = document.getElementsByClassName('user-id')[0].value;


    //var viewModel = { ImageId: imgid, ProfilIdLiked: profilIdLiked };
    fetch('/FeatureImage/LikeImage',
        {
            method: 'POST',
            headers: {
                'Accept': 'application/json; charset=utf-8',
                'Content-Type': 'application/json;charset=UTF-8'
            },
            body: JSON.stringify(imgId)
        })
        .then(x => x.json())
        .then(x => {

            let likesElement = divElement.getElementsByClassName('button-like')[0].querySelectorAll('i')[0];

            likesElement.innerHTML = ' ' + x.count
        }
        )

}))

