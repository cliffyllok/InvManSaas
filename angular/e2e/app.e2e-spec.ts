import { InvManSaasTemplatePage } from './app.po';

describe('InvManSaas App', function() {
  let page: InvManSaasTemplatePage;

  beforeEach(() => {
    page = new InvManSaasTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
