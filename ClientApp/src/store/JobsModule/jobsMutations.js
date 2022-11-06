
export const Mutations = {

    SET_CHART_DATA(state, { page , data }) {
        console.log('SET_CHART_DATA : ' +  data); 
        state.chartData = data;
        state.loading = false;
    },
    SET_CHART_ERROR(state, { error }) {
        console.log('SET_CHART_ERROR : ' + data);
        state.error = error;
    }
};