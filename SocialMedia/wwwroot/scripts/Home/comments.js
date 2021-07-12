﻿let buttonElement = document
    .querySelectorAll('.button-comments')
    .forEach(x => x.addEventListener('click', function (e) {
        let formElement = document.createElement('form');

        let textareaElement = document.createElement('textarea');
        formElement.appendChild(textareaElement)

        let buttonElement = document.createElement('button');
        buttonElement.innerHTML = 'Коментирай'
        buttonElement.classList.add('button-send-comment')
        formElement.appendChild(buttonElement)

        var divElement = e.currentTarget.parentNode.parentNode;

        var imgId = divElement.getElementsByClassName('img-id')[0].value;

        fetch(`FeatureImage/GetComments?ImgId=${imgId}`,
            {
                headers: {
                    'Accept': 'application/json; charset=utf-8',
                    'Content-Type': 'application/json;charset=UTF-8'
                }

            })
            .then(x => x.json())
            .then(x => {

                let count = x[0].comments.length;


                let divElementForComments = document.createElement('div');
                divElementForComments.innerHTML = 'Коментари';
                divElementForComments.classList.add('list-group');
                x[0].comments.forEach(x => {

                    let path = '/Profil/OpenProfil/';
                    let aElement = document.createElement('a');
                    aElement.innerHTML = 'from ' + x.username + ' : ' + x.content;
                    aElement.classList.add('list-group-item');
                    aElement.classList.add('list-group-item-action');

                    aElement.setAttribute('href', path + x.commentingId);

                    divElementForComments.appendChild(aElement);

                })

                divElement.appendChild(divElementForComments)
            })
            .catch(x => console.log(x))



        buttonElement.addEventListener('click', function (e) {
            e.preventDefault();


            var content = textareaElement.value;
            //var imgId = divElement.getElementsByClassName('img-id')[0].value;
            var profilIdCommented = document.getElementsByClassName('user-id')[0].value;

            let divCommentsElement = e.currentTarget.parentNode.parentNode.parentNode.getElementsByClassName('list-group')[0]

            fetch('FeatureImage/AddComment',
                {
                    method: 'POST',
                    headers: {
                        'Accept': 'application/json; charset=utf-8',
                        'Content-Type': 'application/json;charset=UTF-8'
                    },
                    body: JSON.stringify([imgId, content, profilIdCommented])
                })
                .then(x => x.json())
                .then(x => {

                    let path = '/Profil/OpenProfil/';
                    let aElement = document.createElement('a');
                    aElement.innerHTML = 'from ' + x.username + ' : ' + x.content;
                    aElement.classList.add('list-group-item');
                    aElement.classList.add('list-group-item-action');


                    divCommentsElement.appendChild(aElement);

                })




            formElement.remove();
        })

        e.currentTarget.parentNode.appendChild(formElement)

        e.currentTarget.remove();

    }));

