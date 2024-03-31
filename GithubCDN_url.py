# 自动粘贴板，copy(容器)
from clipboard import copy
import time

"""
针对github图床进行快捷生成用于html<img src=图片链接
github参数中必须区分大小写

https://cdn.jsdelivr.net/gh/[github用户名]/[仓库名]@main
https://cdn.jsdelivr.net/gh/lovcoxin/classbook@picturehub/picturebed/[numbering]

？raw=true 图片渲染参数
"""

# 确认编号numbering, 返回一个带编号的git_defaultSet，即git默认参数[list]
def enter_numbering(git_defaultSet):
    talk = str(input("enter goal numbering | 输入目标编号"
                 ": "))

    git_defaultSet.append(talk)
    return git_defaultSet


# 传入一个默认配置列表（git账户名，仓库名，具体分支，目录（仅支持一层目录），图片编号)
# 请求更改并确认配置，函数返回四位列表
def git_info_change(git_defaultSet):
    while True:
        # github_url 图床url访问框架 [我吐了，在这里@不能代表分支，是用tree做目录，@分支的语法应该只是在gitCDN]
        github_rul = 'https://github.com/{}/{}/tree/{}/{}/{}'
        talk = int(input(
            '\n'
            '|About github图床 快捷复制github加速服务的链接 V1.0' + '\n'
            '|`````````````````````````````````````````````' + '\n'
            '|[0]continue' + '\n'
            '|[1]current GitName: ' + git_defaultSet[0] + '\n'
            '|[2]current HubName: ' + git_defaultSet[1] + '\n'
            '|[3]current branches: ' + git_defaultSet[2] + '\n'
            '|[4]current directory: ' + git_defaultSet[3] + '\n'
            '|[5]current numbering: ' + git_defaultSet[4] + '\n'
            '|````````````````````````````````````````' + '\n'
            '|current url:' + github_rul.format(git_defaultSet[0], git_defaultSet[1], git_defaultSet[2], git_defaultSet[3], git_defaultSet[4]) + '?raw=true' + '\n'
            '|wanna change:[nums] '
        ))
        if talk == 0:
            break
        elif talk == 1:
            talk_changeit = input("\n" +
                                  "enter New GirName [注意参数大小写]")
            git_defaultSet[0] = talk_changeit
            continue
        elif talk == 2:
            talk_changeit = input("\n" +
                                  "enter New HubName [注意参数大小写]")
            git_defaultSet[1] = talk_changeit
            continue
        elif talk == 3:
            talk_changeit = input("\n" +
                                  "enter New branches [注意参数大小写]")
            git_defaultSet[2] = talk_changeit
            continue
        elif talk == 4:
            talk_changeit = input("\n" +
                                  "enter New directory [注意参数大小写]")
            git_defaultSet[3] = talk_changeit
            continue
        elif talk == 5:
            talk_changeit = input("\n" +
                                  "enter New numbering [注意参数大小写]")
            git_defaultSet[4] = talk_changeit
            continue
        else:
            print("\n" +
                  "Please enter nums")
            time.sleep(1.5)
            continue

    return git_defaultSet


# 传入四位列表，format并自动粘贴
def copy_GitPicUrl(git_defaultSet):
    # (GitName, HubName, branches, directory文件夹, numbering)

    # 图床url使用CDN（内容分发网络）优化的衍生框架
    power_url = 'https://cdn.jsdelivr.net/gh/{}/{}@{}/{}/{}?raw=true'
    GitPic_url = power_url.format(git_defaultSet[0], git_defaultSet[1], git_defaultSet[2], git_defaultSet[3], git_defaultSet[4])

    copy(GitPic_url)

    print('\n' + GitPic_url + '\n' + 'Copy is COMPLETION!' + '\n')
    time.sleep(1)

    print('wait 3s')
    time.sleep(3)


if __name__ == '__main__':
    # 默认配置信息
    # (GitName, HubName, branches, directory文件夹, numbering)
    git_defaultSet = ['lovcoxin', 'ClassBook', 'PictureHub', 'PictureBed']


    # 一步走，函数真好用^_^，但我写了一个晚上
    copy_GitPicUrl(git_info_change(enter_numbering(git_defaultSet)))
