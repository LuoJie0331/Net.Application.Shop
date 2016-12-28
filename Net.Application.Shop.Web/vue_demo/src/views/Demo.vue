<template>
    <div>
        <fieldset>
            <legend>
                Create New Person
            </legend>
            <div>
                <label>ID:</label>
                <input type="text" v-model="newPerson.id" />
            </div>
            <div>
                <label>Name:</label>
                <input type="text" v-model="newPerson.name" />
            </div>
            <div>
                <label>Score:</label>
                <input type="text" v-model="newPerson.score" />
            </div>
            <button @click="createPerson">Create</button>
        </fieldset>
        <table>
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Score</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="person,index in people">
                    <td>{{person.id}}</td>
                    <td>{{person.name}}</td>
                    <td>{{person.score}}</td>
                    <td><button @click="deletePerson(index)">Delete</button></td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    export default {
      name: 'demo',
      data () {
        return {
          people: [
              {id: 1, name: 'A', score: 100},
              {id: 2, name: 'B', score: 200},
              {id: 3, name: 'C', score: 400}
          ],
          newPerson: {id: 0, name: '', score: 0}
        }
      },
      methods: {
        createPerson () {
          this.people.push(this.newPerson)
          this.newPerson = {id: 0, name: '', score: 0}
        },
        deletePerson (index) {
          console.log(index)
          this.people.splice(index, 1)
        }
      }
    }
</script>

<style scoped>
</style>