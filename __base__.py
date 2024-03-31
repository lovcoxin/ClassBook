from data_info import *

"""
base基础输出，定义函数
"""

# -------------------------------------------------------------
# 全局UI函数
# 函数语法，ui函数传入list参数，list参数为ui字符图中的选项列表
def numui(option_list):
    numb = 1
    init_option = ''

    # 关于init_option部分的适配计算
    for i in option_list:
        option_nums = len(i)

        option_dbug = '    ' + '| ' + '[' + str(numb - 1) + ']' + option_list[numb]

        if numb == 1:
            init_option += option_dbug
            numb += 1
            continue
        else:
            init_option += '\n' + option_dbug
            numb += 1
            continue

# ----------------------- 凛冬将至，北方不是极寒，是极其麻烦

    init_on = '    |' + option_list[0] + '\n' + '    |-----------------------------'


    init_under = """
    |_____________________________

    :[nums] """

    init = init_on + init_option + init_under

    # 函数返回一个UI字符图
    return init

'''
这个函数写我大半天~chan dou
'''

# --------------------------------------------------------
# 全局函数，传入list生成UI交互，根据选项调用函数
# 先决条件是operate_dice有字符串对应函数的记录
def call_in_talk(list):
    while True:
        talk = int(input(numui(list)))

        if talk == 0:
            print("""
            ----------------------------------------------------------
            mainHub        https://github.com/lovcoxin/classbook
            contact me     lovcoxin@126.com

            --
            """)
            continue

        elif 1 <= talk <= int(len(list) - 1):
            x = operate_dict(list[talk])
            x()
            continue

        else:
            print('\n', 'code:', 404)
            continue


# ---numbering函数区----------------------------------------------------

# numbering 编号函数
def PicNumbering():
    # list[标题，选项，选项
    list = ['PictureNumbering 图片编码函数', 'CreateNumbering 创建编号',
            'RetrieveNumbering 检索编号']

    call_in_talk(list)
