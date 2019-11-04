window.Seed = (function () {
  function generateVoteCount() {
    return Math.floor((Math.random() * 50) + 15);
  }

  const products = [
    {
      id: 1,
      title: 'گل گاو زبون اعلا',
      description: 'برای آرامش',
      url: '#',
      votes: generateVoteCount(),
      submitterAvatarUrl: 'images/avatars/daniel.jpg',
      productImageUrl: 'images/products/image-aqua.png',
    },
    {
      id: 2,
      title: 'کندور',
      description: 'برای حافظه',
      url: '#',
      votes: generateVoteCount(),
      submitterAvatarUrl: 'images/avatars/kristy.png',
      productImageUrl: 'images/products/image-rose.png',
    },
    {
      id: 3,
      title: 'بابونه',
      description: 'برای سردرد',
      url: '#',
      votes: generateVoteCount(),
      submitterAvatarUrl: 'images/avatars/veronika.jpg',
      productImageUrl: 'images/products/image-steel.png',
    },
    {
      id: 4,
      title: 'آویشن',
      description: 'برای آلرژی',
      url: '#',
      votes: generateVoteCount(),
      submitterAvatarUrl: 'images/avatars/molly.png',
      productImageUrl: 'images/products/image-yellow.png',
    },
  ];

  return { products: products };
}());
