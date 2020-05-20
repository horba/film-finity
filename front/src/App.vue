<template>
  <div id="app">
    <el-row>
      <el-button>Default</el-button>
      <el-button type="primary">Primary</el-button>
      <el-button type="success">Success</el-button>
      <el-button type="info">Info</el-button>
      <el-button type="warning">Warning</el-button>
      <el-button type="danger">Danger</el-button>
    </el-row>
    <el-menu
      :default-active="activeIndex2"
      class="el-menu-demo"
      mode="horizontal"
      @select="handleSelect"
      background-color="#6663FF"
      text-color="#FFFFFF"
      active-text-color="#FFA21C"
    >
      <el-menu-item index="1">Processing Center</el-menu-item>
      <el-submenu index="2">
        <template slot="title">Workspace</template>
        <el-menu-item index="2-1">item one</el-menu-item>
        <el-menu-item index="2-2">item two</el-menu-item>
        <el-menu-item index="2-3">item three</el-menu-item>
        <el-submenu index="2-4">
          <template slot="title">item four</template>
          <el-menu-item index="2-4-1">item one</el-menu-item>
          <el-menu-item index="2-4-2">item two</el-menu-item>
          <el-menu-item index="2-4-3">item three</el-menu-item>
        </el-submenu>
      </el-submenu>
      <el-menu-item index="3" disabled>Info</el-menu-item>
      <el-menu-item index="4">
        <a href="https://www.ele.me" target="_blank">Orders</a>
      </el-menu-item>
    </el-menu>
    <el-button type="text">Text Button</el-button>
    <el-button type="text" disabled>Text Button</el-button>
    <br />

    <el-button type="primary" icon="el-icon-edit"></el-button>
    <el-button type="primary" icon="el-icon-share"></el-button>
    <el-button type="primary" icon="el-icon-delete"></el-button>
    <el-button type="primary" icon="el-icon-search">Search</el-button>
    <el-button type="primary">
      Upload
      <i class="el-icon-upload el-icon-right"></i>
    </el-button>
    <br />
    <div>
      <el-link href="https://element.eleme.io" target="_blank">default</el-link>
      <el-link type="primary">primary</el-link>
      <el-link type="success">success</el-link>
      <el-link type="warning">warning</el-link>
      <el-link type="danger">danger</el-link>
      <el-link type="info">info</el-link>
    </div>
    <div>
      <el-link disabled>default</el-link>
      <el-link type="primary" disabled>primary</el-link>
      <el-link type="success" disabled>success</el-link>
      <el-link type="warning" disabled>warning</el-link>
      <el-link type="danger" disabled>danger</el-link>
      <el-link type="info" disabled>info</el-link>
    </div>
    <br />
    <el-radio-group v-model="radio1">
      <el-radio-button label="New York"></el-radio-button>
      <el-radio-button label="Washington"></el-radio-button>
      <el-radio-button label="Los Angeles"></el-radio-button>
      <el-radio-button label="Chicago"></el-radio-button>
    </el-radio-group>
    <br />
    <div>
      <el-radio v-model="radio1" label="1" border>Option A</el-radio>
      <el-radio v-model="radio1" label="2" border>Option B</el-radio>
    </div>
    <br />
    <el-checkbox-group v-model="checkList">
      <el-checkbox label="Option A"></el-checkbox>
      <el-checkbox label="Option B"></el-checkbox>
      <el-checkbox label="Option C"></el-checkbox>
      <el-checkbox label="disabled" disabled></el-checkbox>
      <el-checkbox label="selected and disabled" disabled></el-checkbox>
    </el-checkbox-group>

    <div>
      <el-checkbox v-model="checked1" label="Option1" border></el-checkbox>
      <el-checkbox v-model="checked2" label="Option2" border></el-checkbox>
    </div>
    <br />
    <el-input placeholder="Please input" v-model="input"></el-input>
    <el-input placeholder="Please input" v-model="input" :disabled="true"></el-input>
    <el-input placeholder="Please input password" v-model="input" show-password></el-input>
    <el-input placeholder="Please input" v-model="input" clearable></el-input>
    <el-input type="textarea" :rows="2" placeholder="Please input" v-model="textarea"></el-input>
    <el-input type="textarea" autosize placeholder="Please input" v-model="textarea"></el-input>
    <el-select v-model="value" placeholder="Select">
      <br />
    </el-select>
    <el-switch v-model="value1"></el-switch>
    <div class="block">
      <span class="demonstration">Hide Tooltip</span>
      <el-slider v-model="value3" :show-tooltip="false"></el-slider>
    </div>
    <el-progress :percentage="50"></el-progress>
    <el-progress :percentage="100" :format="format"></el-progress>
    <el-progress :percentage="100" status="success"></el-progress>
    <el-progress :percentage="100" status="warning"></el-progress>
    <el-progress :percentage="50" status="exception"></el-progress>
    <div class="block">
      <span class="demonstration">Default</span>
      <el-rate v-model="value1"></el-rate>
    </div>
    <!-- <div>
      <router-link to="/">Home</router-link>
    </div>
    <router-view />-->
  </div>
</template>

<script>
export default {
  name: 'app',
  data () {
    return {
      radio1: 'New York',
      radio2: 'New York',
      radio3: 'New York',
      radio4: 'New York',
      checkList: ['selected and disabled', 'Option A'],
      checked1: true,
      checked2: false,
      activeIndex: '1',
      activeIndex2: '1',
      input: '',
      textarea: '',
      options: [
        {
          value: 'Option1',
          label: 'Option1'
        },
        {
          value: 'Option2',
          label: 'Option2'
        },
        {
          value: 'Option3',
          label: 'Option3'
        },
        {
          value: 'Option4',
          label: 'Option4'
        },
        {
          value: 'Option5',
          label: 'Option5'
        }
      ],
      value: '',
      value1: true,
      value3: 0
    };
  },
  methods: {
    format (percentage) {
      return percentage === 100 ? 'Full' : `${percentage}%`;
    }
  }
};
</script>

<style></style>
